using Project.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogBrands
{
    public interface IGetCatalogBrands
    {
        BaseDto<List<CatalogBrandDto>> Execute();
    }
}
