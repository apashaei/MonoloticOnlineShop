namespace Project.Application.Catalogs.CatalogItemPDP
{
    public class CatalogItemPDPDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }

        public long Price { get; set; }
        public int? OldPrice { get; set; }
        public int? DiscountPerecentage { get; set; }
        public string CategoryType { get; set; }
        public string CategoryBrand { get; set; }
        public List<string> Images { get; set; }
        public string Description { get; set; }
        public IEnumerable<IGrouping<string,PDPFeaturesDto>> Features { get; set; }
        public List<SimilarProductsDto> SimilarProducts { get; set; }
    }
    }
