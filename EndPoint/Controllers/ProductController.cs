using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalogs.CatalogComments.Commands;
using Project.Application.Catalogs.CatalogComments.Queries;
using Project.Application.Catalogs.CatalogItemListPLP;
using Project.Application.Catalogs.CatalogItemPDP;

namespace Project.EndPoint.Controllers
{
    public class ProductController : Controller
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
        public IActionResult Index(CatalogItemListRequestPLP requestPLP)
        {
            
            var result = _catalogItemListPLPService.Execute(requestPLP).Items;
            ViewBag.Brand = requestPLP.BrandId;
            return View(result);
        }

        public IActionResult Details(string Slug)
        {
            var res =  _catalogitemPDPService.Execute(Slug);



            GetCommentListQuery getCommentList = new GetCommentListQuery(res.Id);
            var result = mediator.Send(getCommentList);

            return View(res);
        }

        public IActionResult SendCommnet(CommentDto comment, string Slug)
        {
            SendCommentCommand sendComment = new SendCommentCommand(comment);
            var result = mediator.Send(sendComment).Result;
            return RedirectToAction(nameof(Details), new { Slug = Slug });
        }
    }
}
