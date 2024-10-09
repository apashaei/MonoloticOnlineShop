using Microsoft.AspNetCore.Identity;
using Project.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.User
{
    [Auditable]
    public class User:IdentityUser
    {
        public string FullName { get; set; }
    }
}
