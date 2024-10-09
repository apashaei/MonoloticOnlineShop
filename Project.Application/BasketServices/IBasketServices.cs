using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.BasketServices
{
    public interface IBasketServices
    {
        BasketDto GetOrCreateBasketForUser(string BuyerId);
        BasketDto GetBasketForUser(string BuyerId);
        void TransferBasketToUser(string ananymouseId, string UserId);
    }
}
