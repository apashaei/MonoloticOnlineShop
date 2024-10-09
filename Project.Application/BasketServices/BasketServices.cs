using Microsoft.EntityFrameworkCore;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Baskets;
using System.Runtime.CompilerServices;

namespace Project.Application.BasketServices
{
    public class BasketServices : IBasketServices
    {

        private readonly IDataBaseContext _dbContext;
        private IGetCatalogItemImageSrc _getCatalogItemImageSrc;

        public BasketServices(IDataBaseContext dataBaseContext, IGetCatalogItemImageSrc getCatalogItemImageSrc)
        {
            _dbContext = dataBaseContext;
            _getCatalogItemImageSrc = getCatalogItemImageSrc;
        }

        public BasketDto GetBasketForUser(string BuyerId)
        {
            var basket = _dbContext.Baskets.Include(p => p.Items)
              .ThenInclude(p => p.CatalogItem)
              .ThenInclude(p => p.CatalogImages)
              .Include(p=>p.AppliedDiscount)

              .Include(p => p.Items)
              .ThenInclude(p => p.CatalogItem)
              .ThenInclude(p => p.Discounts)
              .Include(p => p.AppliedDiscount)
              .FirstOrDefault(p => p.BuyerId == BuyerId);

            if (basket == null)
            {
                return null;
            }
            else
            {
                return new BasketDto
                {
                    BuyerId = BuyerId,
                    Id = basket.Id,
                    Items = basket.Items.Select(item => new BasketItemDto
                    {
                        CatalogItemId = item.CatalogItemId,
                        CatalogName = item.CatalogItem.Name,
                        ImageUrl = _getCatalogItemImageSrc.Execute(item?.CatalogItem?.CatalogImages?.FirstOrDefault().Src ?? ""),
                        Quantity = item.Quantity,
                        Id = item.Id,
                        UnitPrice = item.CatalogItem.Price,
                    }).ToList(),
                    DiscountAmount = basket.DiscountAmount,
                };
            }
        }

        public BasketDto GetOrCreateBasketForUser(string BuyerId)
        {
            var basket = _dbContext.Baskets.Include(p=>p.Items)
                .ThenInclude(p=>p.CatalogItem)             
                .ThenInclude(p=>p.CatalogImages)
                .Include(p=>p.AppliedDiscount)

                .Include(p => p.Items)
                .ThenInclude(p => p.CatalogItem)
                .ThenInclude(p => p.Discounts)
                .Include(p => p.AppliedDiscount)

                .FirstOrDefault(p=>p.BuyerId == BuyerId);

            if(basket == null)
            {
                Basket basket1 = new Basket(BuyerId);
                _dbContext.Baskets.Add(basket1);
                _dbContext.SaveChanges();
                return new BasketDto
                {
                    BuyerId = BuyerId,
                    Id = basket1.Id
                };
            }
            else
            {
                return new BasketDto
                {
                    BuyerId = BuyerId,
                    Id = basket.Id,
                    DiscountAmount = basket.DiscountAmount,
                    Items = basket.Items.Select(item => new BasketItemDto
                    {
                        CatalogItemId = item.CatalogItemId,
                        CatalogName = item.CatalogItem.Name,
                        ImageUrl = _getCatalogItemImageSrc.Execute(item?.CatalogItem?.CatalogImages?.FirstOrDefault().Src ?? ""),
                        Quantity = item.Quantity,
                        Id = item.Id,
                        UnitPrice = item.CatalogItem.Price
                    }).ToList(),
                };
            }
        }

        public void TransferBasketToUser(string ananymouseId, string UserId)
        {
            var basket = _dbContext.Baskets.Include(p=>p.Items).Include(p=>p.AppliedDiscount).FirstOrDefault(p=>p.BuyerId==ananymouseId);
            if(basket == null) { return; }

            var userBasket = _dbContext.Baskets.FirstOrDefault(p=>p.BuyerId == UserId);
            if (userBasket == null)
            {
                userBasket = new Basket(UserId);

                foreach (var item in basket.Items)
                {
                    userBasket.AddItem(item.CatalogItemId, item.UnitPrice, item.Quantity);
                }
                if (basket.AppliedDiscount != null)
                {
                    userBasket.ApplyDiscountCode(basket.AppliedDiscount);
                }
                _dbContext.Baskets.Add(userBasket);
            }
            else
            {
                foreach (var item in basket.Items)
                {
                    userBasket.AddItem(item.CatalogItemId, item.UnitPrice, item.Quantity);
                }
                userBasket.ApplyDiscountCode(basket.AppliedDiscount);
                
            }
            
            _dbContext.SaveChanges();
        }
    }
}
