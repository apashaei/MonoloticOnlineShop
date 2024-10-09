namespace Project.Application.Catalogs.CatalogItemListPLP
{
    public class CatalogItemListPLPDto
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string Images { get; set; }
        public byte Rate { get; set; }
        public int availableStock { get; set; }
    }
}
