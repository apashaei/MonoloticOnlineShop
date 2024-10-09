using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence.Seeds
{
    public static class DastaBaseContextSeed
    {
        public static void CatalogSeed(ModelBuilder builder)
        {
            foreach(var item in CatalogSeeds())
            {
                builder.Entity<CatalogType>().HasData(item);
            }

            foreach (var item in CatalogBrandSeeds())
            {
                builder.Entity<CatalogBrand>().HasData(item);
            }
        }

        public static void RoleSeed(ModelBuilder builder)
        {
            foreach (var item in RoleSeed())
            {
                builder.Entity<IdentityRole>().HasData(item);
            }
        }

        private static IEnumerable<CatalogType> CatalogSeeds()
        {
            return new List<CatalogType>
            {
                new CatalogType{Id = 1,Type="کالای دیجیتال"},
                new CatalogType{Id = 2, Type="لوازم جانبی گوشی", ParentCatalogTypeId =1  },
                new CatalogType{Id = 3, Type="پایه نگهدارنده گوشی", ParentCatalogTypeId =2  },
                new CatalogType{Id = 4, Type="پاور بانک", ParentCatalogTypeId =2  },
                new CatalogType{Id = 5, Type="پاور بانک", ParentCatalogTypeId =2  },

            };
        }

        private static IEnumerable<IdentityRole> RoleSeed()
        {
            return new List<IdentityRole>
            {
        
                new IdentityRole{ Id="1", Name="Customer"},
                new IdentityRole{ Id="2", Name="Admin"},
            };
        }

        private static IEnumerable<CatalogBrand> CatalogBrandSeeds()
        {
            return new List<CatalogBrand>
            {
                new CatalogBrand{Id = 1,BrandName="سامسونگ"},
                new CatalogBrand{Id = 2, BrandName="شیامی" },
                new CatalogBrand{Id = 3, BrandName="اپل" },
                new CatalogBrand{Id = 4, BrandName="هوآوی"  },
                new CatalogBrand{Id = 5, BrandName="نوکیا" },
                new CatalogBrand{Id = 6, BrandName="ال جی" },

            };
        }
    }
}
