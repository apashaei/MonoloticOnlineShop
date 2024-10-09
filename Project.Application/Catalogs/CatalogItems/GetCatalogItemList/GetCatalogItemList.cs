using Common;
using Microsoft.EntityFrameworkCore;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogItemList
{
    public class GetCatalogItemList : IGetCatalogItemList
    {

        private readonly IDataBaseContext _context;

        public GetCatalogItemList(IDataBaseContext dataBaseContext)
        {
            _context = dataBaseContext;
        }
        public PagenatedItemDto<CatalogItemListDto> Execute(int page=1, int PageSize = 100)
        
        {
            var rowCount = 0;
            var result = _context.CatalogItems.Include(p=>p.CatalogBrand).Include(p=>p.CatalogType)
                .ToPaged(page, PageSize, out rowCount).Select(p=> new CatalogItemListDto
                {
                    AvailableStock = p.AvailableStock,
                    CatalogBrand = p.CatalogBrand.BrandName,
                    CatalogCategoryType = p.CatalogType.Type,
                    Description = p.Description,
                    MaxStockTreshold = p.MaxStockTreshold,
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    RestockTreshold = p.RestockTreshold,
                }).ToList();

            return new PagenatedItemDto<CatalogItemListDto>(page, PageSize, rowCount, result);
        }
    }
}
