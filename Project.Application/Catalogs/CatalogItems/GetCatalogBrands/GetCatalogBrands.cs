using AutoMapper;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogBrands
{
    public class GetCatalogBrands : IGetCatalogBrands
    {

        private readonly IDataBaseContext _databaseContext;
        private readonly IMapper _mapper;

        public GetCatalogBrands(IDataBaseContext dataBaseContext, IMapper mapper)
        {
            _databaseContext = dataBaseContext;
            _mapper = mapper;
        }
        public BaseDto<List<CatalogBrandDto>> Execute()
        {
            var brands = _databaseContext.CatalogBrands.OrderBy(p=>p.BrandName).Take(500).ToList();
            var mappeddata = _mapper.Map<List<CatalogBrandDto>>(brands);
            return new BaseDto<List<CatalogBrandDto>>(mappeddata, new List<string> { "اطلاعات با موفقیت استخراج شد." }, true);
        }
    }
}
