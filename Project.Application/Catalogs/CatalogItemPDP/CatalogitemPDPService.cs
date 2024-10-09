using Microsoft.EntityFrameworkCore;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.Catalogs.CatalogItemPDP
{
    public class CatalogitemPDPService : ICatalogitemPDPService
    {

        private readonly IDataBaseContext _dbContext;
        private readonly IGetCatalogItemImageSrc _getCatalogItemImageSrc;



        public CatalogitemPDPService(IDataBaseContext dataBaseContext, IGetCatalogItemImageSrc getCatalogItemImageSrc)
        {
            _dbContext = dataBaseContext;
            _getCatalogItemImageSrc = getCatalogItemImageSrc;
        }
        public CatalogItemPDPDto Execute(string Slug)
        {
            var result = _dbContext.CatalogItems.Include(p=>p.Features)
                .Include(p=>p.CatalogBrand)
                .Include(p=>p.CatalogImages)
                .Include(p=>p.Discounts)
                .Include(p => p.CatalogType).SingleOrDefault(p=>p.Slug==Slug);

            result.Visisted += 1;
            _dbContext.SaveChanges();

            var images = result.CatalogImages.Select(p=>_getCatalogItemImageSrc.Execute(p.Src)).ToList();
            var features = result.Features.Select(p => new PDPFeaturesDto
            {
                Group = p.Group,
                Key = p.Key,
                Value = p.Value,
            }).GroupBy(p => p.Group);
            var sismilarProducts = _dbContext.CatalogItems.Include(p=>p.CatalogImages).Where(p=>p.CatalogTypeId == result.CatalogTypeId)
                .Take(10).Select(p=> new SimilarProductsDto
                {
                    Id = p.Id,
                    Image = _getCatalogItemImageSrc.Execute(p.CatalogImages.FirstOrDefault().Src),
                    Name = p.Name,
                    Price = p.Price
                }).ToList();

            return new CatalogItemPDPDto
            {
                Name = result.Name,
                Price = result.Price,
                Description = result.Description,
                Features = features,
                Slug = Slug,
                CategoryBrand = result.CatalogBrand.BrandName,
                CategoryType = result.CatalogType.Type,
                Images = images,
                SimilarProducts = sismilarProducts,
                OldPrice = result.OldPrice,
                DiscountPerecentage = result.Discountperecentage,

            };

        }
    }
    }
