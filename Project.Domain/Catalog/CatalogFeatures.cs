using Project.Domain.Attributes;

namespace Project.Domain.Catalog
{
    [Auditable]
    public class CatalogFeatures
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }

        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; set; }
    }
}
