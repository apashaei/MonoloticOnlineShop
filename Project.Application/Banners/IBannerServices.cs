using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Banners;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Banners
{
    public interface IBannerServices
    {
        void AddBanner(BannerDto banner);
        List<BannerDto> GetBannerList();
    }

    public class BannerServices : IBannerServices
    {
        private readonly IDataBaseContext dataBaseContext;
        private readonly IGetCatalogItemImageSrc getCatalogItemImageSrc;

        public BannerServices(IDataBaseContext dataBaseContext, IGetCatalogItemImageSrc getCatalogItemImageSrc)
        {
            this.dataBaseContext = dataBaseContext;
            this.getCatalogItemImageSrc = getCatalogItemImageSrc;
        }
        public void AddBanner(BannerDto banner)
        {
            var newBanner = new Banner
            {
                IActive = banner.IActive,
                Image = banner.Image,
                Link = banner.Link,
                Name = banner.Name,
                Position = banner.Position,
                Priority = banner.Priority,
            };

            dataBaseContext.Banners.Add(newBanner);
            dataBaseContext.SaveChanges();

        }

        public List<BannerDto> GetBannerList()
        {
            var result = dataBaseContext.Banners.OrderByDescending(p => p.Id).Select(p=> new BannerDto
            {
                IActive=p.IActive,
                Image = getCatalogItemImageSrc.Execute(p.Image),
                Link = p.Link,
                Name = p.Name,
                Position = p.Position,
                Priority = p.Priority,
                Id = p.Id,
            }).ToList();
            return result;
        }
    }

    public class BannerDto
    {
        public int Id { get; set; }

        [Display(Name ="نام بنر")]
        public string Name { get; set; }

        [Display(Name ="تصویر")]
        public string Image { get; set; }

        [Display(Name ="لینک")]

        public string Link { get; set; }

        [Display(Name = "فعال یا غیر فعال")]
        public bool IActive { get; set; }

        [Display(Name = "موقعیت")]
        public Position Position { get; set; }

        [Display(Name = "اولویت")]
        public int Priority { get; set; }
    }
}
