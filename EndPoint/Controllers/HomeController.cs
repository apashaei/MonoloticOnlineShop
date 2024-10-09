using EndPoint.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

using Project.Application.HomePageInfo;
using Project.EndPoint.Utilities.Filters;
using Project.Infrastructure.CacheHelpers;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace EndPoint.Controllers
{
    [ServiceFilter(typeof(SavaVisitorFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomePageInfoServices homePageInfoServices;
        private IDistributedCache distributedCache;

        public HomeController(ILogger<HomeController> logger, IHomePageInfoServices homePageInfoServices,IDistributedCache distributedCache)
        {
            _logger = logger;
            this.homePageInfoServices = homePageInfoServices;
            this.distributedCache = distributedCache;
        }

        public IActionResult Index()
        {
            HomePageInfoDto homePage = new HomePageInfoDto();
            var hompageDats= distributedCache.GetAsync(CacheHelper.HompageCacheKey()).Result;

            if(hompageDats != null)
            {
                homePage = JsonSerializer.Deserialize<HomePageInfoDto>(hompageDats);
            }
            else
            {
                homePage = homePageInfoServices.Getdata();
                var jsonData = JsonSerializer.Serialize(homePage);
                byte[] encodedJson = Encoding.UTF8.GetBytes(jsonData);
                var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(30));
                distributedCache.SetAsync(CacheHelper.HompageCacheKey(), encodedJson, options);
            }

            return View(homePage);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
