namespace Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite
{
    public class FavoriteCatalogitemListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string Images { get; set; }
        public byte Rate { get; set; }

        public int AvailableStock { get; set; }
    }
}
