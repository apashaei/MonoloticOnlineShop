using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.CatalogitemsList;

namespace Admin.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountApiController : ControllerBase
    {
        private readonly ICatalogItemList catalogItemList;

        public DiscountApiController(ICatalogItemList catalogItemList)
        {
            this.catalogItemList = catalogItemList;
        }

        [HttpGet]
        [Route("SerachCatalogItem")]
        public async Task<IActionResult> SerachCatalogItem(string term="")
        {
            
            return Ok(catalogItemList.Execute(term));
        }
    }
}
