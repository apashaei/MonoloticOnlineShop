using Microsoft.EntityFrameworkCore;

using Project.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces.DatabaseContext
{
    public interface IIdentityDataBaseContext
    {
        DbSet<User> Users { get; set; }
   
    }
}
