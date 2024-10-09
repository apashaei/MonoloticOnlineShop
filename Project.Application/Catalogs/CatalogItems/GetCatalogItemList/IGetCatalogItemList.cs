using Project.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogItemList
{
    public interface IGetCatalogItemList
    {
        PagenatedItemDto<CatalogItemListDto> Execute(int page, int PageSize);
    }
}
