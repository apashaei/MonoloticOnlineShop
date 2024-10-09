using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.CatalogItemListPLP;
using Project.Application.Catalogs.CatalogItemPDP;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private readonly ICatalogItemListPLPService _catalogItemListPLPService;
        private readonly ICatalogitemPDPService _catalogitemPDPService;
        private readonly IMediator mediator;

        public ProductController(ICatalogItemListPLPService catalogItemListPLPService, ICatalogitemPDPService catalogitemPDPService, IMediator mediator)
        {
            _catalogItemListPLPService = catalogItemListPLPService;
            _catalogitemPDPService = catalogitemPDPService;
            this.mediator = mediator;
        }
        [HttpGet]
        public IActionResult Index([FromQuery] CatalogItemListRequestPLP requestPLP)
        {
            return Ok(_catalogItemListPLPService.Execute(requestPLP));
        }

    
    }
}
