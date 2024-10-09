using MediatR;
using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogComments.Queries
{
    public class GetCommentListQuery:IRequest<List<GetCommentDto>>
    {
        public int CatalogitemId { get; set; }

        public GetCommentListQuery(int catalogitemId)
        {
            CatalogitemId = catalogitemId;
        }
    }

    public class GetCommentListHandler : IRequestHandler<GetCommentListQuery, List<GetCommentDto>>
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetCommentListHandler(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public Task<List<GetCommentDto>> Handle(GetCommentListQuery request, CancellationToken cancellationToken)
        {
            var calaogItem = dataBaseContext.CatalogItems.Find(request.CatalogitemId);
            var result = dataBaseContext.CatalogItemComments.Include(p=>p.CatalogItem).Where(p=>p.CatalogItemId == request.CatalogitemId).Select(p => new GetCommentDto
            {
                Email = p.Email,
                Id = p.Id,
                Titlte = p.Titlte,
                CatalogItem = p.CatalogItem
            }).ToList();

            return Task.FromResult(result);
        }
    }

    public class GetCommentDto
    {
        public int Id { get; set; }
        public string Titlte { get; set; }

        public string Email { get; set; }
        public CatalogItem CatalogItem { get; set; }
    }
    }
