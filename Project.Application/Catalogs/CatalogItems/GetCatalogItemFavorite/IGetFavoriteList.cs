using Common;
using Microsoft.EntityFrameworkCore;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite
{
    public interface IGetFavoriteList
    {
        PagenatedItemDto<FavoriteCatalogitemListDto> GetMyFavoriteList(string UserId, int page=1, int pageSize=20);
    }

    public class GetFavoriteList : IGetFavoriteList
    {
        private readonly IDataBaseContext dataBaseContext;
        private readonly IGetCatalogItemImageSrc getCatalogItemImageSrc;

        public GetFavoriteList(IDataBaseContext dataBaseContext, IGetCatalogItemImageSrc getCatalogItemImageSrc)
        {
            this.dataBaseContext = dataBaseContext;
            this.getCatalogItemImageSrc = getCatalogItemImageSrc;
        }
        public PagenatedItemDto<FavoriteCatalogitemListDto> GetMyFavoriteList(string UserId, int page = 1, int pageSize = 20)
        {
            var catalogItem = dataBaseContext.CatalogItems.
                Include(p => p.Discounts)
                .Include(p => p.CatalogImages)
                .Include(p => p.CatalogItemFavorites)
                .Where(p => p.CatalogItemFavorites.Any(f => f.UserId == UserId)).OrderByDescending(p=>p.Id).AsQueryable();
            int rowCount = 0;
            var data = catalogItem.PagedResult(page, pageSize,out rowCount).Select(p=>new FavoriteCatalogitemListDto
            {
                Id = p.Id,
                AvailableStock= p.AvailableStock,
                Name = p.Name,
                Rate =4,
                Price = p.Price,
                Images = getCatalogItemImageSrc.Execute(p.CatalogImages.FirstOrDefault().Src??"")

            }).ToList();
            return new PagenatedItemDto<FavoriteCatalogitemListDto>(page, pageSize, rowCount, data);

        }
    }
}
