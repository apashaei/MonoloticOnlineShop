using Admin.EndPoint.ViewModels.Catalog;
using AutoMapper;
using Project.Application.Catalogs.CatalogTypes;

namespace Admin.EndPoint.MappingProfiles
{
    public class CatalogTypeVMProfile:Profile
    {
        public CatalogTypeVMProfile()
        {
            CreateMap<catalogTypeDto,CatalogTypeViewModel>().ReverseMap();
        }
    }
}
