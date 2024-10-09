using Project.Domain.Attributes;

namespace Project.Domain.Catalog
{
    [Auditable]
    public class CatalogImages
    {
        public int Id { get; set; }
        public string Src { get; set; }

        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; set; }
    }
}
