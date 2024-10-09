using Project.Domain.Attributes;

namespace Project.Domain.Catalog
{

    [Auditable]
    public class CatalogType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public CatalogType ParentCatalogType { get; set; }
        public int? ParentCatalogTypeId { get; set; }
        public ICollection<CatalogType> SubType { get; set; }

        public ICollection<CatalogItem> Items { get; set; }
    }

}
