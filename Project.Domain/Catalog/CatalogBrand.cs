using Project.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Catalog
{

    [Auditable]
    public class CatalogBrand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public ICollection<CatalogItem> Items { get; set; }
    }

}
