using Project.Application.Catalogs.CatalogTypes;
using Project.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogTypes
{
    public interface IGetCatalogType
    {
        List<catalogTypeDto> Execute();
    }

}
