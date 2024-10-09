using Project.Domain.Attributes;
using Project.Domain.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Baskets
{

    [Auditable]
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; private set; }

        public int DiscountAmount { get; private set; }

        public Discount1 AppliedDiscount { get; private set; }
        public int? AppliedDiscountId { get; private set; }

        private readonly List<BasketItem> _items= new List<BasketItem>();

        public ICollection<BasketItem> Items => _items.AsReadOnly();

        public Basket(string buyerId)
        {
            this.BuyerId = buyerId;
        }

        public void AddItem(int catalogItemId, int UnitPrice, int quantity)
        {
            if(!Items.Any(p=>p.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem(catalogItemId, UnitPrice, quantity));
                return;
            }
            var existingItem = Items.FirstOrDefault(p=>p.CatalogItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }
        public int TotalPrice()
        {
            int totalPrice = _items.Sum(p=>p.UnitPrice*p.Quantity);  
            totalPrice-=AppliedDiscount.GetDiscountAmount(totalPrice);
            return totalPrice;
        }

        public void RemoveDiscount()
        {
            AppliedDiscount = null;
            AppliedDiscountId = null;
            DiscountAmount = 0;
        }

        public int TotalPriceWithoutDiscount()
        {
            int totalPrice = _items.Sum(p => p.UnitPrice * p.Quantity);
            return totalPrice;
        }

        public void ApplyDiscountCode(Discount1 discount)
        {
            this.AppliedDiscount = discount;
            this.AppliedDiscountId = discount.Id;
            this.DiscountAmount = discount.GetDiscountAmount(this.TotalPriceWithoutDiscount());
        }

    }

    }
