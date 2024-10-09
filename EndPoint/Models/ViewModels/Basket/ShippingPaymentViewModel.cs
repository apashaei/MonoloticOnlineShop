using Project.Application.BasketServices;
using Project.Application.UserServices;

namespace Project.EndPoint.Models.ViewModels.Basket
{
    public class ShippingPaymentViewModel
    {
        public List<UserAddressDto> userAddresses = new List<UserAddressDto>();
        public BasketDto BasketDto { get; set; }
    }
}
