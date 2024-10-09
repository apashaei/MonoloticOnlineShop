using AutoMapper;
using Project.Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Project.Application.Catalogs.CatalogItems.GetCatalogBrands;
using Project.Application.Catalogs.CatalogTypes;
using Project.Application.Catalogs.GetMenuItem;
using Project.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.MappingProfile
{
    public class CatalogMappingProfile:Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<CatalogType, catalogTypeDto>().ReverseMap();

            CreateMap<CatalogType, CategoryTypeListDto>().ForMember(dest => dest.Subcount, options => options.
            MapFrom(src => src.SubType.Count));

            CreateMap<CatalogType, MenuItemDto>()
                .ForMember(des => des.Name, options => options.MapFrom(src => src.Type))
                .ForMember(des=>des.ParentCategoryId, opt=>opt.MapFrom(src=>src.ParentCatalogTypeId))
                .ForMember(des => des.Children, opt => opt.MapFrom(src => src.SubType));

            CreateMap<AddNewCatalogItemDto,CatalogItem>()
                .ForMember(des=>des.CatalogTypeId,opt=>opt.MapFrom(src=>src.CatalogItemCatalogTypeId))
                .ForMember(des=>des.CatalogBrandId, opt=>opt.MapFrom(src=>src.CatalogItemBrandId))
                .ReverseMap();
            CreateMap<CatalogFeatures,NewCatalogFeaturesDto>().ReverseMap();
            CreateMap<CatalogImages,NewCatalogImageDto>().ReverseMap();
            CreateMap<CatalogBrand,CatalogBrandDto>().ReverseMap();

        }
    }
}
