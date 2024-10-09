using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite
{
    public interface IAddToMyFavorites
    {
        void addToMyFavorite(int CatalogsItemId, string UserId);
    }

    public class AddToMyFavorites : IAddToMyFavorites
    {
        private readonly IDataBaseContext dataBaseContext;

        public AddToMyFavorites(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public void addToMyFavorite(int CatalogsItemId, string UserId)
        {
            var catalogItem = dataBaseContext.CatalogItems.FirstOrDefault(p=>p.Id == CatalogsItemId);
            var favorite = new CatalogItemFavorite
            {
                UserId = UserId,
                CatalogItem = catalogItem,
                CatalogItemId = CatalogsItemId
            };
            dataBaseContext.CatalogItemFavorites.Add(favorite);
            dataBaseContext.SaveChangesAsync();
        }
    }

    public class CatalogItemsFavoriteDto
    {
        public int Id { get; set; }
       
        public int CatalogItemId { get; set; }

        public string UserId { get; set; }
    }
}
