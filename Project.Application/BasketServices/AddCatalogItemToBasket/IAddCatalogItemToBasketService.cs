using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.BasketServices.AddCatalogItemToBasket
{
    public interface IAddCatalogItemToBasketService
    {
        void AddCtalogItemToBasket(BasketDto basketDto, int catalogItemId, int quantity = 1);
    }
    public class AddCatalogItemToBasketService : IAddCatalogItemToBasketService
    {
        private readonly IDataBaseContext _dbContext;

        public AddCatalogItemToBasketService(IDataBaseContext dataBaseContext)
        {
            _dbContext = dataBaseContext;
        }
        public void AddCtalogItemToBasket(BasketDto basketDto, int catalogItemId, int quantity = 1)
        {
            var basket = _dbContext.Baskets.FirstOrDefault(p=>p.Id == basketDto.Id);
            if (basket == null)
            {
                throw new Exception();
            }
            else
            {
                var catalogitemPrice = _dbContext.CatalogItems.Include(p=>p.Discounts).FirstOrDefault(p=>p.Id == catalogItemId).Price;
                basket.AddItem(catalogItemId, catalogitemPrice, quantity);
                _dbContext.SaveChanges();
            }
        }
    }
}
