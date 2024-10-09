using Project.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Discount
{
    public class DiscountUsageHistory
    {

        public int Id { get; set; }
        public Order Order { get; set; }
        public int orderId { get; set; }
        public Discount1 Discount1 { get; set; }
        public int DiscountId { get; set; }

        public DateTime InsertDate { get; set; }
    }
}
