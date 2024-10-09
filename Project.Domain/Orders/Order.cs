using Project.Domain.Attributes;
using Project.Domain.Catalog;
using Project.Domain.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Orders
{

    [Auditable]
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; private set; }
        public DateTime OrderDate { get; private set; }=DateTime.Now;
        public Address Address { get; private set; }
        public PaymentMehtos PaymentMehtos { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }
        public Orderstaus Orderstaus { get; private set; }

        public int DiscountAmount { get; private set; }

        public Discount1 AppliedDiscount { get; set; }
        public int? AppliedDiscountId { get; set; }


        private List<OrderItems> _orderItems = new List<OrderItems>();

        public IReadOnlyCollection<OrderItems> Items => _orderItems;

        public Order(string userId, Address address, List<OrderItems> orderItems, PaymentMehtos paymentMehtos,Discount1 discount)
        {
            UserId = userId;
            Address = address;
            PaymentMehtos = paymentMehtos;
            _orderItems = orderItems ?? new List<OrderItems>();
            if (discount != null)
            {
                AppliedDiscountcode(discount);
            }
        }

        public void PaymentDone()
        {
            PaymentStatus = PaymentStatus.Paid;
        }

        public void OrderDelivered()
        {
            Orderstaus = Orderstaus.Delivered;
        }

        public void RemoveDiscount()
        {
            AppliedDiscount = null;
            AppliedDiscountId = null;
            DiscountAmount = 0;
        }

        public int GetSumPrice()
        {
            
           var totalPrice =  _orderItems.Sum(p=>p.UnitPrice * p.Units);
            if (AppliedDiscount != null)
            {
                totalPrice -= AppliedDiscount.GetDiscountAmount(totalPrice);
            }
            return totalPrice;
        }

        public int TotalPriceWithoutDiscount()
        {
            var totalPrice = _orderItems.Sum(p => p.UnitPrice * p.Units);
            return totalPrice;

        }

        public void AppliedDiscountcode(Discount1 discounts)
        {
            this.AppliedDiscount = discounts;
            this.AppliedDiscountId = discounts.Id;
            this.DiscountAmount = discounts.GetDiscountAmount(this.TotalPriceWithoutDiscount());
        }
        public Order()
        {
            
        }
    }


    [Auditable]
    public class OrderItems
    {
        public int Id { get; set; }

        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUri { get; private set; }
        public int UnitPrice { get; private set; }
        public int Units {  get; private set; }


        public OrderItems(int catalogItemId, string productName, string pictureUri, int unitPrice, int units)
        {
            CatalogItemId = catalogItemId;
            ProductName = productName;
            PictureUri = pictureUri;
            UnitPrice = unitPrice;
            Units = units;

        }
        public OrderItems()
        {
            
        }

    }

    public enum Orderstaus
    {
        Processing=0,
        Delivered=1,
        Returned=2,
        Cancelled=3
    }

    public enum PaymentStatus
    {
        WaitingForPayment=0,
        Paid=1
    }

    public enum PaymentMehtos
    {
        OnlinePaymnety=0,
        PaymentOnspot=1
    }

    public class Address
    {
        public int Id { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string PostalAddress { get; private set; }
        public string UserId { get; private set; }
        public string RecieverName { get; private set; }

        public Address(string state, string city, string zipCode, string postalAddress, string userId, string receiverName)
        {
            State = state;
            City= city;
            ZipCode= zipCode;
            PostalAddress= postalAddress;
            UserId= userId;
            RecieverName= receiverName;
        }

        public Address()
        {
            
        }
    }
    }
