using FluentValidation;

namespace Project.Application.Catalogs.CatalogItems.AddNewCatalogItem
{
    public class AddNewCatalogItemDto
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int AvailableStock { get; set; }
        public int RestockTreshold { get; set; }
        public int MaxStockTreshold { get; set; }
        public int CatalogItemBrandId { get; set; }
        public int CatalogItemCatalogTypeId { get; set; }

        public List<NewCatalogFeaturesDto> Features { get; set; }
        public List<NewCatalogImageDto> CatalogImages { get; set; }

    }
    public class AddNewCatalogItemDtoValidator : AbstractValidator<AddNewCatalogItemDto>
    {
        public AddNewCatalogItemDtoValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("نام کاتالوگ باید وارد شود.");
            RuleFor(p => p.Name).Length(0,100);
            RuleFor(p => p.Description).NotNull().WithMessage("توضیحات نمیتواند خالی باشد.");
            RuleFor(p=>p.AvailableStock).LessThanOrEqualTo(int.MaxValue).GreaterThan(0);
            RuleFor(p => p.Price).LessThanOrEqualTo(int.MaxValue).GreaterThan(0).NotNull();

        }
    }
}
