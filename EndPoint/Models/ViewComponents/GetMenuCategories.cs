using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.GetMenuItem;

namespace Project.EndPoint.Models.ViewComponents
{
    public class GetMenuCategories:ViewComponent
    {
        private readonly IGetMenuItem _getMenuItem;
        public GetMenuCategories(IGetMenuItem getMenuItem)
        {
            _getMenuItem = getMenuItem;
        }

        public IViewComponentResult Invoke()
        {
            var data = _getMenuItem.GetMenuItems();
            return View(viewName: "GetMenuCategories",model:data);
        }
    }
}
