using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.BasketServices.SetQuntityService
{
    public class SetQuantityService : ISetQuantityService
    {

        private readonly IDataBaseContext _dbcontext;

        public SetQuantityService(IDataBaseContext dataBaseContext)
        {
            _dbcontext = dataBaseContext;
        }
        public void SetQuantity(int quantity, int catalogItemId)
        {
             _dbcontext.BasketItems.Include(p=>p.CatalogItem).Where(p=>p.CatalogItem.Id == catalogItemId).FirstOrDefault()
                .SetQuantity(quantity);
            _dbcontext.SaveChanges();
        }
    }
}
