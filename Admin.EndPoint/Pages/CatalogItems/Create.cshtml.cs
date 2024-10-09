using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Project.Application.Catalogs.CatalogItems.GetCatalogBrands;
using Project.Application.Catalogs.CatalogItems.GetCatalogTypes;
using Project.Application.Dtos;
using Project.Domain.Catalog;
using Project.EndPoint.Models.ViewModels;
using Project.Infrastructure.ExternalApi.ImageService;
using System.Text.Json;

namespace Admin.EndPoint.Pages.CatalogItems
{

    
    public class CreateModel : PageModel
    {

        private readonly IGetCatalogBrands _getCatalogBrands;
        private readonly IGetCatalogType _getCatalogType;
        private readonly IAddNewCatalogItem _addNewCatalogItem;
        private readonly IUploadImageService _uploadImageService;
        private readonly IMapper _mapper;
        [BindProperty]
    
        public AddNewCatalogItemViewModel Data { get; set; }

        public List<IFormFile> Files { get; set; }
        public List<string> TableRows { get; set; }
        public List<NewCatalogFeaturesDto> Features { get; set; }= new List<NewCatalogFeaturesDto> { };

        public List<string> Messages { get; set; }



        public CreateModel(IGetCatalogBrands getCatalogBrands, IGetCatalogType getCatalogType, IAddNewCatalogItem addNewCatalogItem, IUploadImageService uploadImageService, IMapper mapper)
        {
            _getCatalogBrands = getCatalogBrands;
            _getCatalogType = getCatalogType;
            _addNewCatalogItem = addNewCatalogItem;
            _uploadImageService = uploadImageService;
            _mapper = mapper;
        }

        public SelectList Categories { get; set; } 
        public SelectList Brands { get; set; }


        public void OnGet()
        {
            Categories = new SelectList(_getCatalogType.Execute(),"Id","Type");
            Brands= new SelectList(_getCatalogBrands.Execute().Data,"Id", "BrandName");
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                Messages= allErrors.Select(p => p.ErrorMessage).ToList();
                return Page();
                
            }

            if (!string.IsNullOrEmpty(Data.TableData))
            {
                TableRows = JsonSerializer.Deserialize<List<string>>(Data.TableData);
                foreach (var item in TableRows)
                {
                    var rowsItem = item.Split("__");
                    Features.Add(new NewCatalogFeaturesDto
                    {
                        Group = rowsItem[0],
                        Key = rowsItem[1],
                        Value = rowsItem[2]
                    });
                };
                if(Features.Count ==0)
                {
                    Messages = new List<string>
                    {
                        "افزودن ویژگی الزامی می باشد."
                    };
                    return Page();
                }
              
                // Process the table rows as needed
            }
            List<NewCatalogImageDto> NewCatalogImage = new List<NewCatalogImageDto>();

            for (int i=0; i < Request.Form.Files.Count; i++)
            {
                var files = Request.Form.Files[i];
                Files.Add(files);

            }

            List<string> ImageSourceList; 
         
            if(Files.Count > 0)
            {
                ImageSourceList = _uploadImageService.Upload(Files);
                foreach (var file in ImageSourceList)
                {
                    NewCatalogImage.Add(new NewCatalogImageDto
                    {
                        Src = file,
                    });
                }
            }

            AddNewCatalogItemDto newItem = new AddNewCatalogItemDto()
            {
                AvailableStock = Data.AvailableStock,
                Description = Data.Description,
                MaxStockTreshold = Data.MaxStockTreshold,
                Price = Data.Price,
                Name = Data.Name,
                RestockTreshold = Data.RestockTreshold,
                CatalogItemBrandId = Data.SelectedBrand,
                CatalogItemCatalogTypeId = Data.SelectedCategory,
                CatalogImages = NewCatalogImage,
                Features = Features,

                


            };
            var resultService = _addNewCatalogItem.Execute(newItem);
            Messages = resultService.Massages;
            return RedirectToPage("CatalogItems");
            
        }
    }
}
