using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Application.OrderServices;
using Project.Domain.Orders;
using Project.EndPoint.Utilities;

namespace Project.EndPoint.Areas.Customers.Controllers
{
    [Authorize]
    [Area("Customers")]
    public class OrdersController : Controller
    {
        private readonly IOrderServices orderServices;

        public OrdersController(IOrderServices orderServices)
        {
            this.orderServices = orderServices;
        }
        public IActionResult Index()
        {
            var data = orderServices.GetUserOrders(ClaimUtility.GetUserId(User));

            
            return View(data);
        }
    }
}
