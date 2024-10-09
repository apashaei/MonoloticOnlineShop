using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Application.UserServices;
using Project.EndPoint.Utilities;

namespace Project.EndPoint.Areas.Customers.Controllers
{

    [Area("Customers")]
    [Authorize]
    public class AddressController : Controller
    {

        private readonly IUserServices _userServices;

        public AddressController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public IActionResult Index()
        {
            var res = _userServices.GetUserAddressList(ClaimUtility.GetUserId(User));
            return View(res);
        }

        public IActionResult AddNewAddress()
        {
            return View(new AddUserAddressDto());
        }

        [HttpPost]
        public IActionResult AddNewAddress(AddUserAddressDto addUserAddressDto)
        {
            var userId = ClaimUtility.GetUserId(User);
            addUserAddressDto.UserId = userId;
            _userServices.AddUserAddress(addUserAddressDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
