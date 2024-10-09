using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Payment
{
    public interface IPaymentServices
    {
        PaymentOfOrderDto PayForOrder(int orderId);
        PaymentDto GetPayment(Guid paymentId);

        bool VerifyPayment(Guid Id, string Authority, int RefId);
    }

    public class PaymentServices : IPaymentServices
    {

        private readonly IDataBaseContext _dbContext;
        private readonly IIdentityDataBaseContext _identityDataBaseContext;

        public PaymentServices(IDataBaseContext dataBaseContext, IIdentityDataBaseContext identityDataBaseContext)
        {
            _dbContext = dataBaseContext;
            _identityDataBaseContext = identityDataBaseContext;
        }

        public PaymentDto GetPayment(Guid paymentId)
        {

            ////این قسمت اصلاح شود
            var payment = _dbContext.Payments.Include(p=>p.order.AppliedDiscount).Include(p=>p.order).ThenInclude(p=>p.Items).SingleOrDefault(p=>p.Id == paymentId);
          
            
            var user = _identityDataBaseContext.Users.SingleOrDefault(p => p.Id == payment.order.UserId);

            var description = $"پرداخت سفارش شماره {payment.Id}" + Environment.NewLine;
            description += "محصولات" + Environment.NewLine;
            foreach(var item in payment.order.Items.Select(p => p.ProductName))
            {
                description += $"-{item}";
            }

            return new PaymentDto
            {
                Amount = payment.order.GetSumPrice(),
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Id = paymentId,
                UserId = user.Id,
                Description = description,
            };

        }

        public PaymentOfOrderDto PayForOrder(int OrderId)
        {
            var order = _dbContext.Orders.Include(p=>p.AppliedDiscount).Include(p=>p.Items).Where(p=>p.Id == OrderId).FirstOrDefault();
            if(order == null)
            {
                throw new Exception();
            }
            var payment = _dbContext.Payments.Where(p=>p.OrderId == OrderId).FirstOrDefault();

            if(payment == null)
            {
                payment = new Domain.Payments.Payment(order.GetSumPrice(), order.Id);
                payment.order = order;
                _dbContext.Payments.Add(payment);
                _dbContext.SaveChanges();
            }

            return new PaymentOfOrderDto
            {
                Amount = payment.Amount,
                PaymentId = payment.Id,
                PaymentMehtos = order.PaymentMehtos,
            };
        }

        public bool VerifyPayment(Guid Id, string Authority, int RefId)
        {
            var payment= _dbContext.Payments.Include(p=>p.order).SingleOrDefault(p=>p.Id==Id);
            if (payment == null)
            {
                throw new Exception("Paemnt is null");
            }
            payment.order.PaymentDone();
            payment.PaymentIdDone(Authority, RefId);
            _dbContext.SaveChanges(true);
            return true;

        }
    }

    public class PaymentOfOrderDto
    {
        public Guid PaymentId { get; set; }
        public int Amount { get; set; }
        public PaymentMehtos PaymentMehtos { get; set; }
    }

    public class PaymentDto 
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public string UserId { get; set; }
    }
}
