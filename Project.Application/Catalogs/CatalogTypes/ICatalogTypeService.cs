using Project.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogTypes
{
    public interface ICatalogTypeService
    {
        PagenatedItemDto<CategoryTypeListDto> GetListCatalogTypes(int? ParentId,int Page, int PageSize);
        BaseDto<catalogTypeDto> Add(catalogTypeDto catalogTypeDto);
        BaseDto Remove(int ctalogId);
        BaseDto<catalogTypeDto> Edit(catalogTypeDto catalogTypeDto);
        BaseDto<catalogTypeDto> FindById(int id);

    }
}
