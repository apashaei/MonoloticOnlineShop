using Amazon.Runtime.Internal;
using MediatR;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogComments.Commands
{
    public class SendCommentCommand:IRequest<SendCommentResponseDto>
    {
        public CommentDto Comment { get; set; }

        public SendCommentCommand(CommentDto commentDto)
        {
            Comment = commentDto;
        }
    }

    public class SendCommentHandler : IRequestHandler<SendCommentCommand, SendCommentResponseDto>
    {
        private readonly IDataBaseContext dataBaseContext;

        public SendCommentHandler(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }


        public Task<SendCommentResponseDto> Handle(SendCommentCommand request, CancellationToken cancellationToken)
        {
            var catalogItem = dataBaseContext.CatalogItems.Find(request.Comment.CatalogItemId);

            CatalogItemComment catalogItemComment = new CatalogItemComment()
            {

                Email = request.Comment.Email,
                CatalogItemId = catalogItem.Id,
                Titlte = request.Comment.Titlte,
                CatalogItem = catalogItem
            };
            dataBaseContext.CatalogItemComments.Add(catalogItemComment);
            dataBaseContext.SaveChanges();
            return Task.FromResult(new SendCommentResponseDto
            {
                Id = catalogItemComment.Id
            });
        }
    }

    public class SendCommentResponseDto
    {
        public int Id { get; set; }
    }

    public class CommentDto
    {
        public int Id { get; set; }
        public string Titlte { get; set; }

        public string Email { get; set; }
        public int CatalogItemId { get; set; }
    }
}
