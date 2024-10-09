using Common;
using Microsoft.EntityFrameworkCore;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItemListPLP
{
    public interface ICatalogItemListPLPService
    {
        PagenatedItemDto<CatalogItemListPLPDto> Execute(CatalogItemListRequestPLP catalogItemListRequestPLP);
    }

    public class CatalogItemListPLPService : ICatalogItemListPLPService
    {
        private readonly IDataBaseContext _context;
        private readonly IGetCatalogItemImageSrc _getCatalogItemImage;

        public CatalogItemListPLPService(IDataBaseContext dataBaseContext, IGetCatalogItemImageSrc getCatalogItemImage)
        {
            _context = dataBaseContext;
            _getCatalogItemImage = getCatalogItemImage;
        }
        public PagenatedItemDto<CatalogItemListPLPDto> Execute(CatalogItemListRequestPLP request)
        {
            var totalRowCount = 0;
            var result = _context.CatalogItems.Include(p => p.CatalogImages).Include(p => p.Discounts).AsQueryable();

            if(request.CatalogTypeId != null)
            {
                result = result.Where(p=>p.CatalogTypeId==request.CatalogTypeId);
            }
            if(request.BrandId != null)
            {
                result = result.Where(p=>request.BrandId.Contains(p.CatalogBrandId));
            }
            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                result = result.Where(p=>p.Name.Contains(request.SearchKey) || p.Description.Contains(request.SearchKey));
            }
            if(request.AvaliableStock)
            {
                result = result.Where(p => p.AvailableStock > 0);
            }
            if (request.SortType == SortType.BestSelling)
            {
                result = result.Include(p=>p.OrderItems).OrderByDescending(p=>p.OrderItems.Count);
            }

            if (request.SortType == SortType.Newest)
            {
                result = result.OrderByDescending(p=>p.Id);
            }
            if(request.SortType == SortType.MostVisited)
            {
                result = result.OrderByDescending(p => p.Visisted);
            }
            if(request.SortType == SortType.MostPopular)
            {
                result = result.Include(p=>p.CatalogItemFavorites).OrderByDescending(p=>p.CatalogItemFavorites
                .Count);
            }
            if(request.SortType == SortType.Cheapest)
            {
                result = result.OrderBy(p=>p.Price);
            }

            if (request.SortType == SortType.MostExpensive)
            {
                result = result.OrderByDescending(p => p.Price);
            }


            var data = result.ToPaged(request.page, request.pageSize, out totalRowCount)
                .ToList().Select(
                p=> new CatalogItemListPLPDto
                {
                    Id = p.Id,
                    Slug = p.Slug,
                    Name = p.Name,
                    Price = p.Price,
                    Images = _getCatalogItemImage.Execute(p.CatalogImages.FirstOrDefault()?.Src),
                    Rate = 5,
                    availableStock = p.AvailableStock,
                  
                });
            return new PagenatedItemDto<CatalogItemListPLPDto>(request.page, request.pageSize, totalRowCount,data);
        }
    }

    public class CatalogItemListRequestPLP
    {
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public int? CatalogTypeId { get; set; }
        public int[]? BrandId { get; set; }
        public bool AvaliableStock {  get; set; }
        public string? SearchKey { get; set; } = null;
        public SortType SortType { get; set; }

    }

    public enum SortType
    {
        None=0,
        MostVisited = 1,
        BestSelling = 2,
        MostPopular = 3,
        Newest = 4,
        Cheapest = 5,
        MostExpensive = 6,
    }
}
