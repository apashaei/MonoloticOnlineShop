using API.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite;
using Project.Domain.User;
using System.IdentityModel.Tokens.Jwt;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
   
    public class FavoriteItemControllerController : ControllerBase
    {
        private readonly IAddToMyFavorites addToMyFavorites;
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> userManager;
        private readonly IGetFavoriteList getFavoriteList;

        public FavoriteItemControllerController(IAddToMyFavorites addToMyFavorites, UserManager<User> userManager, IGetFavoriteList getFavoriteList)
        {
            this.addToMyFavorites = addToMyFavorites;
            this.userManager = userManager;
            this.getFavoriteList = getFavoriteList;
        }

        [HttpGet]
        public IActionResult GetFavoriteItems(int page = 1, int PageSize = 20)
        {
            var accessToken =  HttpContext.GetTokenAsync("access_token").Result;

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(accessToken);

            // Extract the UserId claim
            var userIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "UserId");

            var data = getFavoriteList.GetMyFavoriteList(userIdClaim.Value, page, PageSize);
            return Ok(data);
        }
    }
}
