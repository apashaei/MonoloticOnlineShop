namespace Project.EndPoint.Models.ViewModels
{
    public class AddNewCatalogItemViewModel
    {
       

            public string Name { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public int AvailableStock { get; set; }
            public int RestockTreshold { get; set; }
            public int MaxStockTreshold { get; set; }
            public int SelectedCategory { get; set; }
            public int SelectedBrand { get; set; }
            public List<IFormFile> Images { get; set; }
            public string TableData { get; set; }
        }

    
}
