using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.CatalogItems.GetCatalogBrands;

namespace Project.EndPoint.Models.ViewComponents
{
    public class GetBrandList:ViewComponent
    {
        private readonly IGetCatalogBrands getCatalogBrands;

        public GetBrandList(IGetCatalogBrands getCatalogBrands)
        {
            this.getCatalogBrands = getCatalogBrands;
        }
        public IViewComponentResult Invoke()
        {
            var data = getCatalogBrands.Execute().Data;
            return View(viewName: "GetBrandList", model: data);
        }
    }
}
