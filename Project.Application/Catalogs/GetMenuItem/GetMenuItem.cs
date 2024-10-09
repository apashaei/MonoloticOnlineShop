using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;

namespace Project.Application.Catalogs.GetMenuItem
{
    public class GetMenuItem : IGetMenuItem
    {

        private readonly IDataBaseContext _dataBaseContext;
        private readonly IMapper _mapper;
        public GetMenuItem(IDataBaseContext dataBaseContext,IMapper mapper)
        {
            _dataBaseContext = dataBaseContext;
            _mapper = mapper;
        }
        public List<MenuItemDto> GetMenuItems()
        {
            var result = _dataBaseContext.CatalogTypes.Include(p=>p.ParentCatalogType).ToList();
            var model = _mapper.Map<List<MenuItemDto>>(result);
            return model;
        }
    }
}
