using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Domain.User;
using Project.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.IdentityConfigs
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityDataBaseContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<IdentityDataBaseContext>()
                .AddDefaultTokenProviders()
                .AddRoles<IdentityRole>()
                .AddErrorDescriber<CustomIdentityError>();

            services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = true;


                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);

            });

            services.ConfigureApplicationCookie(options =>
            {
                //نشان می دهد که بعد از 5 دقیقه به صورت خودکار از سیستم خارج شود.
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Home/login";
                options.AccessDeniedPath = "/AccessDenied/";
                options.SlidingExpiration = true;
            });



            return services;
        }
    }
}
