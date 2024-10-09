using AutoMapper;
using Common;
using Project.Application.Dtos;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.User;

namespace Project.Application.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly IDataBaseContext _dbContext;
        private readonly IIdentityDataBaseContext identityDataBaseContext;
        private readonly IMapper _mapper;

        public UserServices(IDataBaseContext dataBaseContext, IMapper mapper, IIdentityDataBaseContext identityDataBaseContext)
        {
            _dbContext = dataBaseContext;
            _mapper = mapper;
            this.identityDataBaseContext = identityDataBaseContext;
        }

        public void AddUserAddress(AddUserAddressDto addUserAddressDto)
        {
            var model = _mapper.Map<UserAddress>(addUserAddressDto);
            _dbContext.UserAddresses.Add(model);
            _dbContext.SaveChanges();
        }

        public List<UserAddressDto> GetUserAddressList(string UserId)
        {
            var addresses = _dbContext.UserAddresses.Where(p=>p.UserId == UserId);
             return _mapper.Map<List<UserAddressDto>>(addresses);

        }

      

      
    }
}
