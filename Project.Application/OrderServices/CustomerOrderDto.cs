using Project.Domain.Orders;

namespace Project.Application.OrderServices
{
    public class CustomerOrderDto
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public Orderstaus Orderstaus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public int price { get; set; }
    }
}
