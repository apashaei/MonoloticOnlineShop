using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.BasketServices;
using Project.Application.BasketServices.AddCatalogItemToBasket;
using Project.Application.BasketServices.DeleteCatalogItemFromBasketService;
using Project.Application.BasketServices.SetQuntityService;
using Project.Application.Discount;
using Project.Application.Dtos;
using Project.Application.OrderServices;
using Project.Application.Payment;
using Project.Application.UserServices;
using Project.Domain.Baskets;
using Project.Domain.Orders;
using Project.Domain.User;
using Project.EndPoint.Models.ViewModels.Basket;
using Project.EndPoint.Utilities;
using System.Runtime.CompilerServices;

namespace Project.EndPoint.Controllers
{

    [Authorize]
    public class BasketController : Controller
    {

        private readonly IBasketServices _basketServices;
        private SignInManager<User> _signInManager;
        private readonly IAddCatalogItemToBasketService _addCatalogItemToBasketService;
        private readonly IOrderServices _orderServices;
        private readonly ISetQuantityService _setQuantityService;
        private readonly IUserServices _userServices;
        private readonly IPaymentServices _paymentServices;
        private readonly IDiscountServices _discountServices;
        private readonly UserManager<User> userManager;
        private readonly IDeleteItemFromBaseket _deleteItemFromBaseket;
        private string UserId = null;

        public BasketController(IBasketServices basketServices, SignInManager<User> signInManager,
            IAddCatalogItemToBasketService addCatalogItemToBasketService,
            IDeleteItemFromBaseket deleteItemFromBaseket,
            ISetQuantityService setQuantityService
            , IUserServices userServices, IOrderServices orderServices, IPaymentServices paymentServices,
            IDiscountServices discountServices, UserManager<User> userManager)
        {
            _basketServices = basketServices;
            _signInManager = signInManager;
            _addCatalogItemToBasketService = addCatalogItemToBasketService;
            _deleteItemFromBaseket = deleteItemFromBaseket;
            _setQuantityService = setQuantityService;
            _userServices = userServices;
            _orderServices = orderServices;
            _paymentServices = paymentServices;
            _discountServices = discountServices;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {

            BasketDto basketDto = null;


            if (_signInManager.IsSignedIn(User))
            {
                basketDto = _basketServices.GetOrCreateBasketForUser(ClaimUtility.GetUserId(User));
            }
            else
            {
                SetOrGetCookie();
                basketDto = _basketServices.GetOrCreateBasketForUser(UserId);

            }
            return View(basketDto);
        }

        [HttpPost]
        [AllowAnonymous]

        public IActionResult ApplyDiscount(string CouponCode, int BasketId)
        {
            var user = userManager.GetUserAsync(User).Result;
            var valid = _discountServices.CheckDiscountIsValid(CouponCode, user);
            if (valid.IsSuccess)
            {
                _discountServices.AddDiscountToBasket(CouponCode, BasketId);
            }
            else
            {
                TempData["Message"] = string.Join(Environment.NewLine, valid.Massages.Select(a => string.Join(",", a)));
            }
            return RedirectToAction(nameof(Index));

        }

        [AllowAnonymous]
        public IActionResult RemoveDiscount(int BasketId)
        {
            _discountServices.RemoveDiscountFromBasket(BasketId);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public IActionResult SetQuantity(int catalogItemId, int quantity)
        {
            _setQuantityService.SetQuantity(quantity, catalogItemId);
            return RedirectToAction("Index");
        }


        [AllowAnonymous]
        public IActionResult RemoveCatalogItem(int CatalogItemId)
        {
            _deleteItemFromBaseket.Delete(CatalogItemId);
            return RedirectToAction("Index");
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index(int catalogItemId, int quantity = 1)
        {
            BasketDto basketDto = null;
            if (_signInManager.IsSignedIn(User))
            {
                basketDto = _basketServices.GetOrCreateBasketForUser(ClaimUtility.GetUserId(User));
                _addCatalogItemToBasketService.AddCtalogItemToBasket(basketDto, catalogItemId, quantity);
            }

            else
            {
                SetOrGetCookie();
                basketDto = _basketServices.GetOrCreateBasketForUser(UserId);
                _addCatalogItemToBasketService.AddCtalogItemToBasket(basketDto, catalogItemId, quantity);

            }

            return RedirectToAction(nameof(Index));

        }


       

        private void SetOrGetCookie()
        {
            string BasketCookieName = "BasketId";
            if (Request.Cookies.ContainsKey(BasketCookieName))
            {
                UserId = Request.Cookies[BasketCookieName];
            }
            else
            {
                UserId = Guid.NewGuid().ToString();
                var cookieoptions = new CookieOptions { IsEssential = true };
                cookieoptions.Expires = DateTime.Now.AddYears(2);
                Response.Cookies.Append(BasketCookieName, UserId, cookieoptions);
            }
        }

        public IActionResult ShippingPayment()
        {
            ShippingPaymentViewModel viewModel = new ShippingPaymentViewModel();
            UserId = ClaimUtility.GetUserId(User);
            viewModel.userAddresses = _userServices.GetUserAddressList(UserId);
            viewModel.BasketDto = _basketServices.GetBasketForUser(UserId);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ShippingPayment(int Address, PaymentMehtos paymentMethod)
        {
            var basket = _basketServices.GetBasketForUser(ClaimUtility.GetUserId(User));
            int orderId = _orderServices.CreateOrder(basket.Id, Address, paymentMethod);
            if(paymentMethod ==PaymentMehtos.OnlinePaymnety)
            {
                var payment = _paymentServices.PayForOrder(orderId);
                return RedirectToAction("Index","Pay", new {paymentId = payment.PaymentId});
            }
            else
            {
                return RedirectToAction("Index", "Orders", new { area = "customers" });
            }
        }
    }
}
