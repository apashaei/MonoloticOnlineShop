using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;

using Project.Domain.User;
using Project.Persistence.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence
{
    public class IdentityDataBaseContext : IdentityDbContext<User>, IIdentityDataBaseContext
    {
        public IdentityDataBaseContext(DbContextOptions<IdentityDataBaseContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<IdentityUserLogin<string>>().HasKey(p => new { p.LoginProvider, p.ProviderKey });
            builder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });
            builder.Entity<IdentityUserToken<string>>().HasKey(p => new { p.UserId, p.LoginProvider, p.Name });
            builder.Entity<IdentityUser<string>>().ToTable("Users", "Identity");
            builder.Entity<IdentityRole<string>>().ToTable("Roles", "Identity");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Identity");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Identity");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Identity");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Identity");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Identity");
            DastaBaseContextSeed.RoleSeed(builder);

        }
    }
}
