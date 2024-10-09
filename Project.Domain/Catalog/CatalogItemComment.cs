using Project.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Catalog
{
    [Auditable]
    public class CatalogItemComment
    {
        public int Id { get; set; }
        public string Titlte { get; set; }

        public string Email { get; set; }
        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; set; }
        
    }
}
