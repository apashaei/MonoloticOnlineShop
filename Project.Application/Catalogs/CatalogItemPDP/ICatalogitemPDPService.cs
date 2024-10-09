using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalogs.CatalogItemPDP
{
    public interface ICatalogitemPDPService
    {
        CatalogItemPDPDto Execute(string Slug);
    }
}
