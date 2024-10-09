using Admin.EndPoint.ViewModels.Catalog;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalogs.CatalogTypes;

namespace Admin.EndPoint.Pages.CatalogType
{
    public class EditModel : PageModel
    {

        private readonly ICatalogTypeService _catalogTypeService;
        private readonly IMapper _mapper;

        [BindProperty]
        public CatalogTypeViewModel catalogTypeViewModel { get; set; }= new CatalogTypeViewModel();
        public List<string> Messages = new List<string>();

        public EditModel(ICatalogTypeService catalogTypeService, IMapper mapper)
        {
            _catalogTypeService = catalogTypeService;
            _mapper = mapper;
        }
        public void OnGet(int id)
        {
            catalogTypeViewModel.Id= id;
            catalogTypeViewModel.Type = _catalogTypeService.FindById(id).Data.Type;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var model = _mapper.Map<catalogTypeDto>(catalogTypeViewModel);
            var result = _catalogTypeService.Edit(model);
            if (result.IsSuccess)
            {
                Messages = result.Massages;
                return Page();
            }
            else
            {
                Messages = result.Massages;
                return Page();
            }
        }
    }
}
