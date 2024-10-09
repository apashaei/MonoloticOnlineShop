using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalogs.CatalogTypes;
using Project.Application.Dtos;

namespace Admin.EndPoint.Pages.CatalogType
{

   
    
    public class IndexModel : PageModel
    {

        private readonly ICatalogTypeService _catalogTypeService;
        public PagenatedItemDto<CategoryTypeListDto> pagenatedItemDto { get; set; }
        public IndexModel(ICatalogTypeService catalogTypeService)
        {
            _catalogTypeService = catalogTypeService;
        }
        public void OnGet(int? id, int PageIndex=1, int PageSize=20)
        {
            pagenatedItemDto = _catalogTypeService.GetListCatalogTypes(id, PageIndex, PageSize);
        }
    }
}
