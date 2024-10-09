using Project.Domain.Attributes;
using Project.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Discount
{

    [Auditable]
    public class Discount1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool UsePrecentage { get; set; }
        public int DiscountPerecentage { get; set; }

        public int DiscountAmount { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool RequiredCouponCode { get; set; }
        public string CouponCode { get; set; }

        [NotMapped]
        public DiscountType DiscountType
        {
            get => (DiscountType)this.DiscountTypeId;
            set => this.DiscountTypeId = (int)value;
        }
        public int DiscountTypeId { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }

        public int LimitaionTime { get; set; }


        [NotMapped]
        public DiscountLimitation Limitation
        {
            get => (DiscountLimitation)this.DiscountLimitationId;
            set => this.DiscountLimitationId = (int)value;
        }
        public int DiscountLimitationId { get; set; }

        public int GetDiscountAmount(int amount)
        {
            var result = 0;
            if (UsePrecentage)
            {
                result = (((amount) * (DiscountPerecentage)) / 100);
            }
            else result = DiscountAmount;
            return result;
        }
    }

    public enum DiscountType
    {
        [Display(Name = "تخفیف برای محصولات")]
        AssignedProduct = 1,
        [Display(Name = "تخفیف برای دسته بندی")]
        AssignedToCategories = 2,

        [Display(Name = "تخفیف برای کاربران")]
        AssignedToUser = 3,

        [Display(Name = "تخفیف برای برندها")]
        AssignToBrand = 4,

    }

    public enum DiscountLimitation
    {

        [Display(Name = "تعداد دفعات استفاده نامحدود")]
        Unlimited = 1,

        [Display(Name = "تعداد دفعات استفاده N بار")]
        NTimeOnly = 2,

        [Display(Name = "N بار به ازای هر مشتری")]
        NTimePerCustomer = 3,

    }
}
