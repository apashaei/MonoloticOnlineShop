using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.BasketServices.SetQuntityService
{
    public interface ISetQuantityService
    {
        void SetQuantity(int quantity, int catalogItemId);
    }
}
