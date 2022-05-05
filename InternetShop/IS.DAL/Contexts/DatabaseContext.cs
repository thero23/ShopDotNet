using IS.DAL.Contexts.Configurations;
using IS.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Contexts
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }

   #nullable disable 
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProviderCountryEntity> ProviderCountries { get; set; }
        public DbSet<BasketEntity> Baskets { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderProductEntity> OrdersProducts { get; set; }
        public DbSet<ProductBasketEntity> ProductsBaskets { get; set; }

#nullable enable
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Entity<CurrencyEntity>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Name = "BYN",
                        Sign = "BYN",
                    },
                    new
                    {
                        Id = 2,
                        Name = "USD",
                        Sign = "$",
                    },
                    new
                    {
                        Id = 3,
                        Name = "EUR",
                        Sign = "€",
                    }
                );
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });

            modelBuilder.Entity<UserEntity>()
                .HasOne(a => a.Basket)
                .WithOne(b => b.User)
                .HasForeignKey<BasketEntity>(b => b.UserId);

            modelBuilder.Entity<OrderEntity>()
                .HasOne(a => a.User)
                .WithMany(b => b.Orders)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<ProductEntity>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<ProductEntity>()
                .HasOne(p => p.Currency)
                .WithMany(c => c.Products)
                .HasForeignKey(x => x.CurrencyId);

            modelBuilder.Entity<ProductEntity>()
                .HasOne(x => x.ProviderCountry)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.ProviderCountryId);

            modelBuilder.Entity<ProductBasketEntity>()
                .HasKey(ub => new { ub.BasketId, ub.ProductId });
            modelBuilder.Entity<ProductBasketEntity>()
                .HasOne(ub => ub.Basket)
                .WithMany(b => b.ProductBasketEntities)
                .HasForeignKey(bc => bc.BasketId);
            modelBuilder.Entity<ProductBasketEntity>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.ProductBasketEntities)
                .HasForeignKey(bc => bc.ProductId);

            modelBuilder.Entity<OrderProductEntity>()
                .HasKey(op => new { op.ProductId, op.OrderId });
            modelBuilder.Entity<OrderProductEntity>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProductEntities)
                .HasForeignKey(op => op.OrderId);
            modelBuilder.Entity<OrderProductEntity>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProductEntities)
                .HasForeignKey(op => op.ProductId);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);

        }
        
    }
}
