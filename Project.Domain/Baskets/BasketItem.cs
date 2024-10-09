using Project.Domain.Attributes;
using Project.Domain.Catalog;

namespace Project.Domain.Baskets
{
    [Auditable]
    public class BasketItem
    {
        public int Id { get; set; }
        public int UnitPrice { get; private set; }
        public int Quantity { get; private set; }

        public int CatalogItemId { get; private set; }
        public CatalogItem CatalogItem { get; private set; }

        public int BasketId { get; private set; }

        public BasketItem(int CatalogItemId, int UnitPrice, int quantity)
        {
            this.Quantity = quantity;
            this.CatalogItemId = CatalogItemId;
            this.UnitPrice = UnitPrice;
        }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }

    }
