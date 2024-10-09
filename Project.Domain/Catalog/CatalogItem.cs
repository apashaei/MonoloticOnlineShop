using Project.Domain.Attributes;
using Project.Domain.Discount;
using Project.Domain.Orders;

namespace Project.Domain.Catalog
{
    [Auditable]
    public class CatalogItem
    {

        private int _price;
        private int? _oldPrice;
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }

        public int Visisted { get; set; }
        public int Price
        {
            get
            {
                return GetPriceWithDiscount();
            }
            set
            {
                Price=_price;
            }
        }

        public int? OldPrice
        {
            get
            {
                return _oldPrice;
            }
            set
            {
                OldPrice=_price;
            }
        }
        public int? Discountperecentage { get; set; }
        public int CatalogTypeId { get; set; }
        public CatalogType CatalogType { get; set; }

        public int AvailableStock { get; set; }

        public int RestockTreshold { get; set; }
        public int MaxStockTreshold { get; set; }
        public CatalogBrand CatalogBrand { get; set; }
        public int CatalogBrandId { get; set; }
        public ICollection<CatalogFeatures> Features { get; set; }  

        public ICollection<CatalogImages> CatalogImages { get; set; }
        public ICollection<Discount1> Discounts { get; set; }

        public ICollection<CatalogItemFavorite> CatalogItemFavorites { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }

        private int GetPriceWithDiscount()
        {
            var dis = GetPreferredDiscount(Discounts,_price);
            if (dis != null)
            {
                var discountamount = dis.GetDiscountAmount(_price);
                int newPrice = _price-discountamount;
                _oldPrice = _price;
                Discountperecentage = (discountamount*100)/_price;
                return newPrice;
            }
            return _price;
        }
        private Discount1 GetPreferredDiscount(ICollection<Discount1> discounts, int price)
        {
            Discount1 preferredDiscount = null;
            decimal? maximumDiscount = 0;
            if (discounts != null)
            {
                foreach(var dsicount in discounts)
                {
                    var currentDiscountValue = dsicount.GetDiscountAmount(price);
                    if(currentDiscountValue != decimal.Zero)
                    {
                        if(maximumDiscount .HasValue || currentDiscountValue > maximumDiscount)
                        {
                            maximumDiscount = currentDiscountValue;
                            preferredDiscount = dsicount;
                        }
                    }
                }
            }
            return preferredDiscount;
        }
    }
}
