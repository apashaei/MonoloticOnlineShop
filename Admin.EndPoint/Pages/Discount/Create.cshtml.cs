using Admin.EndPoint.Binders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Project.Application.Discount;

namespace Admin.EndPoint.Pages.Discount
{
    public class CreateModel : PageModel
    {

        [ModelBinder(BinderType=typeof(DiscountEntityBinder))]
        [BindProperty]
        public AddNewDiscountDto model {  get; set; }

        private readonly IDiscountServices _discountServices;

        public CreateModel(IDiscountServices discountServices)
        {
            _discountServices = discountServices;   
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            _discountServices.AddNewDiscount(model);
        }
    }
}
