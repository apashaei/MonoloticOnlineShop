using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Catalog
{
    public class CatalogItemFavorite
    {
        public int Id { get; set; }
        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; set; }

        public string UserId { get; set; }
    }
}
