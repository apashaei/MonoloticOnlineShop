using Admin.EndPoint.ViewModels.Catalog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalogs.CatalogTypes;

namespace Admin.EndPoint.Pages.CatalogType
{
    public class RemoveModel : PageModel
    {
        private readonly ICatalogTypeService _catalogTypeService;

        [BindProperty]
        public CatalogTypeViewModel catalogTypeViewModel { get; set; }=new CatalogTypeViewModel();
        public List<string> Message { get; set; } = new List<string>();

        public RemoveModel(ICatalogTypeService catalogTypeService)
        {
            _catalogTypeService = catalogTypeService;
        }
        public void OnGet(int id)
        {
            catalogTypeViewModel.Id = id;
            catalogTypeViewModel.Type =_catalogTypeService.FindById(id).Data.Type;
        }
        public IActionResult OnPost()
        {
            var result = _catalogTypeService.Remove(catalogTypeViewModel.Id);
            if (result.IsSuccess)
            {
                return RedirectToPage("Index");
            }
            else
            {
                Message = result.Massages;
                return Page();
            }
        }
    }
}
