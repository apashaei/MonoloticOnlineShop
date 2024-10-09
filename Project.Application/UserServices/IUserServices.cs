using Microsoft.AspNetCore.Identity;
using Project.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.UserServices
{
    public interface IUserServices
    {
        List<UserAddressDto> GetUserAddressList(string UserId);
        void AddUserAddress(AddUserAddressDto addUserAddressDto);
       
    }


}
