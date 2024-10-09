using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Project.Application.Banners;
using Project.Infrastructure.CacheHelpers;
using Project.Infrastructure.ExternalApi.ImageService;

namespace Admin.EndPoint.Pages.Banners
{
    public class AddBannercshtmlModel : PageModel
    {
        private readonly IBannerServices banner1;
        private readonly IUploadImageService _uploadImageService;
        private readonly IDistributedCache cache;

        public AddBannercshtmlModel(IBannerServices banner, IUploadImageService uploadImageService,IDistributedCache cache)
        {
            banner1 = banner;
            _uploadImageService = uploadImageService;
            this.cache = cache;
        }

        [BindProperty]
        public BannerDto model {  get; set; }

        [BindProperty]

        public IFormFile BannerImage { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            var uploadedImage = _uploadImageService.Upload(new List<IFormFile> { BannerImage });
            if (uploadedImage.Count > 0)
            {
                model.Image = uploadedImage.FirstOrDefault();
                banner1.AddBanner(model);
                cache.RemoveAsync(CacheHelper.HompageCacheKey());
            }
            return RedirectToPage("AddBannercshtml");
        }
    }
}
