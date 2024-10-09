using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Discount;
using Project.Domain.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Discount
{
    public interface IDiscountServices
    {
        void AddNewDiscount(AddNewDiscountDto addNew);
        bool AddDiscountToBasket(string couponCode, int BasketId);
        void RemoveDiscountFromBasket(int basketId);
        BaseDto CheckDiscountIsValid(string couponcode, User user);
    }

    public class DiscountServices : IDiscountServices
    {

        private readonly IDataBaseContext _context;
        private readonly IDiscountHistoryService discountHistoryService;

        public DiscountServices(IDataBaseContext dataBaseContext, IDiscountHistoryService discountHistoryService)
        {
            _context = dataBaseContext;
            this.discountHistoryService = discountHistoryService;
        }

        public bool AddDiscountToBasket(string couponCode, int BasketId)
        {
            var basket = _context.Baskets.Include(p => p.Items).Include(p => p.AppliedDiscount).FirstOrDefault(p => p.Id == BasketId);
            var discount = _context.Discount1s.FirstOrDefault(p => p.CouponCode.Equals(couponCode));
            basket.ApplyDiscountCode(discount);
            _context.SaveChanges();
            return true;
        }

        public void AddNewDiscount(AddNewDiscountDto addNew)
        {
            var addNewDiscount = new Discount1
            {
                CouponCode = addNew.CouponCode,
                DiscountAmount = addNew.DiscountAmount,
                DiscountLimitationId = addNew.DiscountLimitationId,
                DiscountPerecentage = addNew.DiscountPerecentage,
                DiscountTypeId = addNew.DiscountTypeId,
                EndDate = addNew.EndDate,
                Name = addNew.Name,
                UsePrecentage = addNew.UsePrecentage,
                RequiredCouponCode = addNew.RequiredCouponCode,
                LimitaionTime = addNew.LimitaionTime,
                StartDate = addNew.StartDate,


            };

            if (addNew.CatalogItemIds != null)
            {
                addNewDiscount.CatalogItems = _context.CatalogItems.Where(p => addNew.CatalogItemIds.Contains(p.Id)).ToList();
            }

            _context.Discount1s.Add(addNewDiscount);
            _context.SaveChanges();
        }

        public BaseDto CheckDiscountIsValid(string couponcode, User user)
        {
            var discount = _context.Discount1s.FirstOrDefault(p => p.CouponCode.Equals(couponcode));
            if (discount == null)
            {
                return new BaseDto(new List<string> { "کد تخفیف معتبر نمی باشد." }, false);
            }
            var date = DateTime.Now;
            if (discount.StartDate.HasValue)
            {
                var StartDate = DateTime.SpecifyKind(discount.StartDate.Value, DateTimeKind.Utc);
                if (StartDate.CompareTo(date) > 0)
                {
                    return new BaseDto(new List<string> { "هنوز زمان استفاده از کد تخفیف فرا نرسیده است." }, false);
                }
            }

            if (discount.EndDate.HasValue)
            {
                var EndDate = DateTime.SpecifyKind(discount.EndDate.Value, DateTimeKind.Utc);
                if (EndDate.CompareTo(date) < 0)
                {
                    return new BaseDto(new List<string> { "زمان استفاده از این کد تخفیف به پایان رسیده است." }, false);
                }
            }

            var check = CheckDiscountIsValid(couponcode, user);
            if (!check.IsSuccess)
            {
                return check;
            }
            else
            {
                return new BaseDto(null, true);
            }


        }

        public BaseDto CheckDiscountLimitation(Discount1 discount, User user)
        {
            switch (discount.Limitation)
            {
                case DiscountLimitation.Unlimited:
                    {
                        return new BaseDto(null, true);
                    }
                case DiscountLimitation.NTimeOnly:
                    {
                        var count = discountHistoryService.GetAllDiscountUsageHistory(discount.Id, null).Items.Count();
                        if (count > discount.LimitaionTime)
                        {
                            return new BaseDto(new List<string> { "تعداد دفعات استفاده از این لیست به پایان رسیده است." }, false);
                        }
                        return new BaseDto(null, true);
                    }
                case DiscountLimitation.NTimePerCustomer:
                    {
                        if (user != null)
                        {
                            var count = discountHistoryService.GetAllDiscountUsageHistory(discount.Id, user.Id).Items.Count();

                            if (count > discount.LimitaionTime)
                            {
                                return new BaseDto(new List<string> { "تعداد دفعات استفاده از این لیست به پایان رسیده است." }, false);
                            }
                            return new BaseDto(null, true);
                        }
                        else
                        {
                            return new BaseDto(null, true);

                        }
                    }
                default:
                    {
                        return new BaseDto(null, true);
                    }

            }
        }

        public void RemoveDiscountFromBasket(int basketId)
        {
            var basket = _context.Baskets.FirstOrDefault(p => p.Id == basketId);
            basket.RemoveDiscount();
            _context.SaveChanges();
        }
    }

    public class AddNewDiscountDto
    {

        [Display(Name = "نام تخفیف")]
        public string Name { get; set; }

        [Display(Name = "استفاده از درصد؟")]
        public bool UsePrecentage { get; set; }

        [Display(Name = "درصد تخفیف")]
        public int DiscountPerecentage { get; set; }

        [Display(Name = "مبلغ تخفیف")]
        public int DiscountAmount { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "تاریخ پایان")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "استفاده از کپن")]
        public bool RequiredCouponCode { get; set; }

        [Display(Name = "کد کپن")]
        public string CouponCode { get; set; }

        [Display(Name = "نوع تخفیف")]
        public int DiscountTypeId { get; set; }
        [Display(Name = "محدودیت تخفیف")]

        public int DiscountLimitationId { get; set; }

        [Display(Name = "تعداد کد تخفیف")]
        public int LimitaionTime { get; set; }


        [Display(Name = "محصولات")]

        public List<int> CatalogItemIds { get; set; }
    }

}