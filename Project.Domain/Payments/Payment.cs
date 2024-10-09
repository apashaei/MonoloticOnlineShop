using Project.Domain.Attributes;
using Project.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Payments
{

    [Auditable]
    public class Payment
    {
        public Guid Id { get; set; }

        public int Amount { get; private set; }
        public bool IsPay {  get; private set; }=false;
        public DateTime? DatePay { get; private set; } = null;
        public long RefId { get; set; } = 0;

        public Order order { get; set; }
        public int OrderId { get; set; }
        public Payment(int amount, int orderId)
        {
            Amount = amount;
            OrderId = orderId;

        }

        public void PaymentIdDone(string authority, long refId)
        {
            IsPay = false;
            DatePay = DateTime.Now;
            RefId = refId;
        }
    }
}
