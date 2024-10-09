using AutoMapper;
using Project.Application.UserServices;
using Project.Domain.Orders;
using Project.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.MappingProfile
{
    public class UserMappingProfile:Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserAddress,UserAddressDto>().ReverseMap();
            CreateMap<AddUserAddressDto, UserAddress>().ReverseMap();
            CreateMap<UserAddress, Address>().ReverseMap();
        }
    }
}
