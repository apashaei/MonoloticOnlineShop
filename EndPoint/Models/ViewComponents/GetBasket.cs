using Microsoft.AspNetCore.Mvc;
using Project.Application.BasketServices;
using Project.Domain.User;
using Project.EndPoint.Utilities;
using System.Security.Claims;

namespace Project.EndPoint.Models.ViewComponents
{
    public class GetBasket:ViewComponent
    {

        private readonly IBasketServices _basketServices;

        public GetBasket(IBasketServices basketServices)
        {
            _basketServices = basketServices;
        }
        private ClaimsPrincipal userClaimPrincipal => ViewContext?.HttpContext?.User;
        public IViewComponentResult Invoke()
        {
            BasketDto basket = new BasketDto();
            
            if (User.Identity.IsAuthenticated)
            {
                basket = _basketServices.GetBasketForUser(ClaimUtility.GetUserId(userClaimPrincipal));
                if (basket == null)
                {
                    return View(viewName: "GetBasket", model:new BasketDto());
                }
            }
            else
            {
                string BasketCookieName = "BasketId";
                if (Request.Cookies.ContainsKey(BasketCookieName))
                {
                    var buyerId = Request.Cookies[BasketCookieName];
                    basket = _basketServices.GetBasketForUser(buyerId);
                }
            }
       
            return View(viewName: "GetBasket", model:basket);
        } 
    }
}
