using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Application._ٍExceptions;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Discount;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Orders;

namespace Project.Application.OrderServices
{
    public class OrderServices : IOrderServices
    {

        private readonly IGetCatalogItemImageSrc _getCatalogItemImageSrc;
        private readonly IDiscountHistoryService discountHistoryService;
        private readonly IDataBaseContext _dbContext;
        private readonly IMapper _mapper;

        public OrderServices(IDataBaseContext dataBaseContext, IMapper mapper,IGetCatalogItemImageSrc getCatalogItemImageSrc, IDiscountHistoryService discountHistoryService)
        {
            _dbContext = dataBaseContext;
            _mapper = mapper;
            _getCatalogItemImageSrc= getCatalogItemImageSrc;
            this.discountHistoryService = discountHistoryService;
        }
        public int CreateOrder(int basketId, int UserAddressId, PaymentMehtos paymentMehtos)
        {
            var basket = _dbContext.Baskets.Include(p=>p.Items).Include(p=>p.AppliedDiscount).Where(p=>p.Id == basketId).FirstOrDefault();

            if (basket == null)
            {
                throw new NotFoundException(nameof(basket),basketId);
            }

            int[] Ids = basket.Items.Select(p=>p.CatalogItemId).ToArray();
            var catalogItems = _dbContext.CatalogItems.Where(p => Ids.Contains(p.Id));
            var orderItems = basket.Items.Select(basketItem =>
            {
                var catalogItem = _dbContext.CatalogItems.Include(p => p.CatalogImages).FirstOrDefault(p => p.Id == basketItem.CatalogItemId);
                var orderItem = new OrderItems(catalogItem.Id, catalogItem.Name,
                    _getCatalogItemImageSrc.Execute(catalogItem.CatalogImages?.FirstOrDefault()?.Src),
                    catalogItem.Price,
                    basketItem.Quantity);
                return orderItem;
            }).ToList();

            var useraddress = _dbContext.UserAddresses.SingleOrDefault(p=>p.Id == UserAddressId);
            var mappedUseraddress = _mapper.Map<Address>(useraddress);
            var order = new Order(basket.BuyerId, mappedUseraddress, orderItems, paymentMehtos,basket.AppliedDiscount);
            _dbContext.Orders.Add(order);
            _dbContext.Baskets.Remove(basket);
            _dbContext.SaveChanges();

            if(basket.AppliedDiscount != null)
            {
                discountHistoryService.InsertDiscountUsageHistory(basket.AppliedDiscount.Id, order.Id);
            }
            return order.Id;
        }

        public List<CustomerOrderDto> GetUserOrders(string UserId)
        {
            var orders = _dbContext.Orders.Where(p=>p.UserId == UserId);
            if (orders != null)
            {
                var result = orders.Include(p=>p.Items).OrderByDescending(p => p.Id).Select(p => new CustomerOrderDto
                {
                    Id = p.Id,
                    Date = _dbContext.Entry(p).Property("InsertTime").CurrentValue.ToString(),
                    Orderstaus = p.Orderstaus,
                    PaymentStatus = p.PaymentStatus,
                    price = p.GetSumPrice()
                }).ToList();
                return result;
            }
            else { return new List<CustomerOrderDto>(); }
        }
    }
}
