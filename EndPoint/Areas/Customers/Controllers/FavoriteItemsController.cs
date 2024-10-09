using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite;
using Project.Application.Token;
using Project.Domain.User;
using Project.EndPoint.Areas.Customers.Utilities;
using Project.EndPoint.Utilities;
using RestSharp;
using System.Drawing.Printing;
using System.Net;
using System.Runtime.CompilerServices;

namespace Project.EndPoint.Areas.Customers.Controllers
{
    [Area("Customers")]
    [Authorize]
    public class FavoriteItemsController : Controller
    {
        private readonly IAddToMyFavorites addToMyFavorites;
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> userManager;
        private readonly IGetFavoriteList getFavoriteList;
        private readonly ITokenServices tokenServices;

        public FavoriteItemsController(IAddToMyFavorites addToMyFavorites, UserManager<User> userManager, IGetFavoriteList getFavoriteList,
            ITokenServices tokenServices)
        {
            this.addToMyFavorites = addToMyFavorites;
            this.userManager = userManager;
            this.getFavoriteList = getFavoriteList;
            this.tokenServices = tokenServices;
        }
        public IActionResult Index(int page=1, int PageSize=20)
        {

            var data = getFavoriteList.GetMyFavoriteList(ClaimUtility.GetUserId(User), page, PageSize);
            return View(data.Items);
        }


        public IActionResult AddToFavorite(int CatalogItemId)
        {
            addToMyFavorites.addToMyFavorite(CatalogItemId, ClaimUtility.GetUserId(User));
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GetFavoritesUsingAPI()
        {
            var token= tokenServices.GetUserTokn(ClaimUtility.GetUserId(User));
            var options = new RestClientOptions("https://localhost:7071")
            {
                MaxTimeout = -1,
            };

            if (token != null)
            {

              
                var client = new RestClient(options);
                var request = new RestRequest("/api/FavoriteItemController", Method.Get);

                request.AddQueryParameter("page", "1");
                request.AddQueryParameter("PageSize", "20");

                // Add Authorization header with JWT token
                request.AddHeader("Authorization", $"Bearer {token.Token}");
              
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    var request1 = new RestRequest($"/api/UserAccount/SendRefreshToken?refreshToken={token.RefreshToken}", Method.Get);
                    request.AddHeader("Authorization", $"Bearer {token.Token}");
                    RestResponse response1 = client.Execute(request1);
                }

                return Json(response);
            }
            return View();
      

           

        }
    }
}
