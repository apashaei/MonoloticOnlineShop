using Project.Application.Interfaces.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogitemsList
{
    public interface ICatalogItemList
    {
        List<CatalogItemListDto> Execute(string serachKey);
    }

    public class CatalogItemList : ICatalogItemList
    {
        private readonly IDataBaseContext dataBaseContext;

        public CatalogItemList(IDataBaseContext dataBaseContext)
        {
           this.dataBaseContext = dataBaseContext;
        }

        public List<CatalogItemListDto> Execute(string serachKey)
        {
            if (!string.IsNullOrEmpty(serachKey))
            {
                var result = dataBaseContext.CatalogItems.Where(p => p.Name.Contains(serachKey)).Select(p => new CatalogItemListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                }).ToList();
                return result;
            }
            else
            {
                var result = dataBaseContext.CatalogItems.Take(10).Select(p => new CatalogItemListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                }).OrderByDescending(p=>p.Id).ToList();
                return result;
            }
        }
    }

    public class CatalogItemListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
