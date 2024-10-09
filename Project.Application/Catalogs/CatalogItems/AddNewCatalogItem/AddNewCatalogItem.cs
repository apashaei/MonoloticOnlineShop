using AutoMapper;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Catalog;

namespace Project.Application.Catalogs.CatalogItems.AddNewCatalogItem
{
    public class AddNewCatalogItem : IAddNewCatalogItem
    {
        private readonly IDataBaseContext _dataBaseContext;
        private readonly IMapper _mapper;

        public AddNewCatalogItem(IDataBaseContext dataBaseContext,IMapper mapper)
        {
            _dataBaseContext = dataBaseContext;
            _mapper = mapper;
        }
        public BaseDto<int> Execute(AddNewCatalogItemDto addNewCatalogItemDto)
        {
            var mapped = _mapper.Map<CatalogItem>(addNewCatalogItemDto);
            _dataBaseContext.CatalogItems.Add(mapped);
            _dataBaseContext.SaveChanges();
            return new BaseDto<int>(mapped.Id, new List<string> { "ثبت با موفقیت انجام شد." }, true);
        }
    }
}
