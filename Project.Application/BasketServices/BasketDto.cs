namespace Project.Application.BasketServices
{
    public class BasketDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }

        public int DiscountAmount { get; set; }

        public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();

        public int SumPriceWithoutDiscount()
        {
            if(Items.Count == 0) return 0;
            return Items.Sum(p=>p.Quantity * p.UnitPrice);
        }

        public int SumPriceWithDiscountAmount()
        {
            if (Items.Count == 0) return 0;
            var totalPrice =  Items.Sum(p => p.Quantity * p.UnitPrice);
            totalPrice -= DiscountAmount;
            return totalPrice;
        }
    }
}
