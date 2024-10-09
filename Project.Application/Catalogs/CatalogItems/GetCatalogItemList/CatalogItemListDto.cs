namespace Project.Application.Catalogs.CatalogItems.GetCatalogItemList
{
    public class CatalogItemListDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int AvailableStock { get; set; }
        public int RestockTreshold { get; set; }
        public int MaxStockTreshold { get; set; }
        public string CatalogBrand { get; set; }
        public string CatalogCategoryType { get; set; }
    }
}
