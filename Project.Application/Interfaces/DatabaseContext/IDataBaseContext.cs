using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Project.Domain.Banners;
using Project.Domain.Baskets;
using Project.Domain.Catalog;
using Project.Domain.Discount;
using Project.Domain.Orders;
using Project.Domain.Payments;
using Project.Domain.Token;
using Project.Domain.User;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces.DatabaseContext
{
    public interface IDataBaseContext
    {
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogFeatures> CatalogFeatures { get; set; }
        public DbSet<CatalogImages> CatalogImages { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Domain.Payments.Payment> Payments { get; set; }

        public DbSet<Discount1> Discount1s { get; set; }
        public DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }

        public DbSet<CatalogItemFavorite> CatalogItemFavorites { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<CatalogItemComment> CatalogItemComments { get; set; }
        public DbSet<Tokens> Tokens { get; set; }





        public int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry Entry([NotNullAttribute] object entity);

    }
}
