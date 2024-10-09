using Project.Application.Dtos;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItems.AddNewCatalogItem
{
    public interface IAddNewCatalogItem
    {
        BaseDto<int> Execute(AddNewCatalogItemDto addNewCatalogItemDto);
    }
}
