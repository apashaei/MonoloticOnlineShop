using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Catalogs.CatalogItemListPLP;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Banners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.HomePageInfo
{
    public interface IHomePageInfoServices
    {
        HomePageInfoDto Getdata();
    }

    public class HomePageInfoServices : IHomePageInfoServices
    {
        private readonly IDataBaseContext dataBaseContext;
        private readonly IGetCatalogItemImageSrc getCatalogItemImageSrc;
        private readonly ICatalogItemListPLPService catalogItemListPLPService;

        public HomePageInfoServices(IDataBaseContext dataBaseContext, IGetCatalogItemImageSrc getCatalogItemImageSrc,
            ICatalogItemListPLPService catalogItemListPLPService)
        {
            this.dataBaseContext = dataBaseContext;
            this.getCatalogItemImageSrc = getCatalogItemImageSrc;
            this.catalogItemListPLPService = catalogItemListPLPService;
        }
        public HomePageInfoDto Getdata()
        {
            var banners = dataBaseContext.Banners.Where(p=>p.IActive).Select(p=>new HomPageBannerDto
            {
                Id = p.Id,
                Image = getCatalogItemImageSrc.Execute(p.Image),
                Link = p.Link,
                Position = p.Position,
                Priority = p.Priority,
                Name = p.Name,
            }).ToList();

            var mostPopular = catalogItemListPLPService.Execute(new CatalogItemListRequestPLP
            {
                AvaliableStock = true,
                SortType = SortType.MostPopular,
                page = 1,
                pageSize = 20
            }).Items.ToList();

            var bestSellers = catalogItemListPLPService.Execute(new CatalogItemListRequestPLP
            {
                AvaliableStock = true,
                SortType = SortType.BestSelling,
                page = 1,
                pageSize = 20
            }).Items.ToList();

            return new HomePageInfoDto
            {
                BsetSellers = bestSellers,
                homPageBannerDtos = banners,
                MostPopulars = mostPopular,
            };
        }
    }
        public class HomePageInfoDto
    {
        public List<HomPageBannerDto> homPageBannerDtos { get; set; }
        public List<CatalogItemListPLPDto> MostPopulars { get; set; }
        public List<CatalogItemListPLPDto> BsetSellers { get; set; }
    }

    public class HomPageBannerDto
    {
        public int Id { get; set; }
       public string Name { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        
        public Position Position { get; set; }
        public int Priority { get; set; }
    }

}
