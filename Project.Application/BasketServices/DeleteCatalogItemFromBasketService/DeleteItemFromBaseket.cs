using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.BasketServices.DeleteCatalogItemFromBasketService
{
    public class DeleteItemFromBaseket : IDeleteItemFromBaseket
    {
        public IDataBaseContext _dbcontext;

        public DeleteItemFromBaseket(IDataBaseContext dataBaseContext)
        {
            _dbcontext = dataBaseContext;
        }
        public void Delete(int CatalogItemId)
        {
            var basketItem = _dbcontext.BasketItems.Include(p => p.CatalogItem)
                .Where(p => p.CatalogItemId == CatalogItemId).FirstOrDefault();
            _dbcontext.BasketItems.Remove(basketItem);
            _dbcontext.SaveChanges();
           
        }
    }
}
