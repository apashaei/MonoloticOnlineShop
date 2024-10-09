using AutoMapper;
using Common;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Catalog;

namespace Project.Application.Catalogs.CatalogTypes
{
    public class CatalogTypeService : ICatalogTypeService
    {

        private readonly IDataBaseContext _dataBaseContext;
        private readonly IMapper _mapper;
        public CatalogTypeService(IDataBaseContext dataBaseContext,IMapper mapper)
        {
            _dataBaseContext = dataBaseContext;
            _mapper = mapper;
        }
        public BaseDto<catalogTypeDto> Add(catalogTypeDto catalogTypeDto)
        {
            var model = _mapper.Map<CatalogType>(catalogTypeDto);
             _dataBaseContext.CatalogTypes.Add(model);
            _dataBaseContext.SaveChangesAsync();
            var res = _mapper.Map<catalogTypeDto>(model);
            return new BaseDto<catalogTypeDto>(res,new List<string> { "افزودن با موفقیت انجام شد" },true);
        }

        public BaseDto<catalogTypeDto> Edit(catalogTypeDto catalogTypeDto)
        {
            var result = _dataBaseContext.CatalogTypes.FirstOrDefault(p=>p.Id == catalogTypeDto.Id);
            _mapper.Map(catalogTypeDto,result);
            _dataBaseContext.SaveChanges();
            return new BaseDto<catalogTypeDto>(_mapper.Map<catalogTypeDto>(result), new List<string> { "اپدیت با موفقیت انجام شد." }, true); ;

        }

        public BaseDto<catalogTypeDto> FindById(int id)
        {
            var catalog = _dataBaseContext.CatalogTypes.FirstOrDefault(c => c.Id == id);
            var result = _mapper.Map<catalogTypeDto>(catalog);
            return new BaseDto<catalogTypeDto>(
                result,null,true
                );
        }

        public PagenatedItemDto<CategoryTypeListDto> GetListCatalogTypes(int? ParentId, int Page, int PageSize)
        {
            var totalcount = 0;
            var result = _dataBaseContext.CatalogTypes.Where(p=>p.ParentCatalogTypeId==ParentId).PagedResult(Page,PageSize,out totalcount);
            var model = _mapper.ProjectTo<CategoryTypeListDto>(result).ToList();
            return new PagenatedItemDto<CategoryTypeListDto>(Page,PageSize,totalcount,model);
        }

        public BaseDto Remove(int ctalogId)
        {
            var catalogType = _dataBaseContext.CatalogTypes.FirstOrDefault(p=>p.Id==ctalogId);
            _dataBaseContext.CatalogTypes.Remove(catalogType);
            _dataBaseContext.SaveChanges();
            return new BaseDto(new List<string> { $"حذف تایپ {catalogType.Type}با موفقیت انجام شد."},true);
        }
    }
}
