using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Attributes;
using Project.Domain.Banners;
using Project.Domain.Baskets;
using Project.Domain.Catalog;
using Project.Domain.Discount;
using Project.Domain.Orders;
using Project.Domain.Payments;
using Project.Domain.Token;
using Project.Domain.User;
using Project.Persistence.EntityConfigurations.CatalogEntities;
using Project.Persistence.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence
{
    public class DataBaseContext:DbContext,IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

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
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Discount1> Discount1s { get; set; }
        public DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        public DbSet<CatalogItemFavorite> CatalogItemFavorites { get; set; }
        public DbSet<CatalogItemComment> CatalogItemComments { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Tokens> Tokens { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute), true).Length>0)
                {
                    modelBuilder.Entity(entityType.Name).Property<DateTime>("InsertTime").HasDefaultValue(DateTime.Now);
                    modelBuilder.Entity(entityType.Name).Property<DateTime?>("UpdateTime");
                    modelBuilder.Entity(entityType.Name).Property<DateTime?>("RemoveTime");
                    modelBuilder.Entity(entityType.Name).Property<bool>("IsRemoved").HasDefaultValue(false);
                }
            }
            modelBuilder.ApplyConfiguration(new CataLogBrandConfig());
            modelBuilder.ApplyConfiguration(new CataLogBrandConfig());
            modelBuilder.ApplyConfiguration(new CatalogItemConfig());
            DastaBaseContextSeed.CatalogSeed(modelBuilder);
            

            modelBuilder.Entity<CatalogType>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved")==false);
            modelBuilder.Entity<Basket>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved")==false);
            modelBuilder.Entity<BasketItem>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved")==false);
            modelBuilder.Entity<UserAddress>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved")==false);
            modelBuilder.Entity<Tokens>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved")==false);
            modelBuilder.Entity<Tokens>().HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved")==false);
            modelBuilder.Entity<Order>().OwnsOne(p => p.Address);
            
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modefiedEntries = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified ||
                p.State == EntityState.Added ||
                p.State == EntityState.Deleted);
            foreach(var entry in modefiedEntries)
            {
                var entityType = entry.Context.Model.FindEntityType(entry.Entity.GetType());
                if (entityType != null)
                {
                    var inserted = entityType.FindProperty("InsertTime");
                    var updated = entityType.FindProperty("UpdateTime");
                    var removeTime = entityType.FindProperty("RemoveTime");
                    var removed = entityType.FindProperty("IsRemoved");
                    if (entry.State == EntityState.Added && inserted != null)
                    {
                        entry.Property("InsertTime").CurrentValue = DateTime.Now;
                    }
                    if (entry.State == EntityState.Modified && updated != null)
                    {
                        entry.Property("UpdateTime").CurrentValue = DateTime.Now;
                    }
                    if (entry.State == EntityState.Deleted && removed != null && removeTime != null)
                    {
                        entry.Property("RemoveTime").CurrentValue = DateTime.Now;
                        entry.Property("IsRemoved").CurrentValue = true;
                        entry.State = EntityState.Modified;
                    }
                }
            }
            return base.SaveChanges();
        }

    }
}
