using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalogs.CatalogItems.GetCatalogItemList;
using Project.Application.Dtos;

namespace Admin.EndPoint.Pages.CatalogItems
{
    public class IndexModel : PageModel
    {

        private readonly IGetCatalogItemList _getCatalogitemList;

        public PagenatedItemDto<CatalogItemListDto> pagenatedItemDto { get; set; }
        public IndexModel(IGetCatalogItemList getCatalogItemList)
        {
            _getCatalogitemList = getCatalogItemList;
        }
        public void OnGet(int page=1, int PageSize=100)
        {
            pagenatedItemDto =  _getCatalogitemList.Execute(page, PageSize);
        }
    }
}
