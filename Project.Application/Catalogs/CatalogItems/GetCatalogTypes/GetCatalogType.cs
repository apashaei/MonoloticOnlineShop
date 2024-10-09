using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Application.Catalogs.CatalogTypes;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.Catalogs.CatalogItems.GetCatalogTypes
{
    public class GetCatalogType : IGetCatalogType
    {

        public IDataBaseContext _dataBaseContext;
        private readonly IMapper _mapper;

        public GetCatalogType(IDataBaseContext dataBaseContext, IMapper mapper)
        {
            _dataBaseContext = dataBaseContext;
            _mapper = mapper;
        }
        public List<catalogTypeDto> Execute()
        {
            var types = _dataBaseContext.CatalogTypes.Include(p => p.ParentCatalogType)
                .Include(p => p.ParentCatalogType)
                .ThenInclude(p => p.ParentCatalogType.ParentCatalogType)
                .Include(p => p.SubType)
                .Where(p => p.ParentCatalogTypeId != null)
                .Where(p => p.SubType.Count == 0)
                .Select(p => new { p.Id, p.Type, p.ParentCatalogType }).
                Select(p => new catalogTypeDto
                {
                    Id = p.Id,
                    Type = $"{p.Type ?? ""}-{p.ParentCatalogType.Type ?? ""}-{p.ParentCatalogType.ParentCatalogType.Type ?? ""}"
                }).ToList();



            return types;
        }
    }

}
