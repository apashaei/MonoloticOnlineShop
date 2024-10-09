using Common;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Discount;
using Project.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Discount
{
    public interface IDiscountHistoryService
    {
        void InsertDiscountUsageHistory(int discountId, int orderId);
        DiscounUsageHistoryDto GetDiscountUsageHistory(int discountUsageHistoryId);
        PagenatedItemDto<DiscounUsageHistoryDto> GetAllDiscountUsageHistory(int? discountId, string? UserId, int PageIndex=1, int PageSize=20);

    }

    public class DiscountHistoryService : IDiscountHistoryService
    {
        private readonly IDataBaseContext dataBaseContext;

        public DiscountHistoryService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public PagenatedItemDto<DiscounUsageHistoryDto> GetAllDiscountUsageHistory(int? discountId, string? UserId, int PageIndex, int PageSize)
        {
            var query = dataBaseContext.DiscountUsageHistories.AsQueryable();
            if(discountId.HasValue && discountId.Value > 0)
            {
                query = query.Where(p=>p.DiscountId == discountId);
            }
            if (!string.IsNullOrEmpty(UserId))
            {
                query= query.Where(p=>p.Order.UserId==UserId);
            }
            query = query.OrderByDescending(p=>p.InsertDate);
            var result = query.Select(p=> new DiscounUsageHistoryDto
            {
               Id = p.Id,
               orderId  = p.orderId,
               DiscountId = p.DiscountId,
            }).ToList();
            var pageItem = query.PagedResult(PageIndex, PageSize, out int rowCount);
            return new PagenatedItemDto<DiscounUsageHistoryDto>(PageIndex,PageSize,rowCount,result);
        }

        public DiscounUsageHistoryDto GetDiscountUsageHistory(int discountUsageHistoryId)
        {
            return dataBaseContext.DiscountUsageHistories.Select(p => new DiscounUsageHistoryDto
            {
                Id = p.Id,
                DiscountId = p.DiscountId,
                orderId = p.orderId
            }).FirstOrDefault(p => p.Id == discountUsageHistoryId);
        }

        public void InsertDiscountUsageHistory(int discountId, int orderId)
        {
            var discount=dataBaseContext.Discount1s.FirstOrDefault(p => p.Id == discountId);
            var order = dataBaseContext.Orders.FirstOrDefault(p => p.Id == discountId);

            var discountUsageHistory = new DiscountUsageHistory()
            {
                orderId = order.Id,
                Order = order,
                Discount1 = discount,
                DiscountId = discount.Id
            };
        }
    }

    public class DiscounUsageHistoryDto
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int orderId { get; set; }
        public int DiscountId { get; set; }

    }


}
