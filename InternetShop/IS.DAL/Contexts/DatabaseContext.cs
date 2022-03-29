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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });

            modelBuilder.Entity<UserEntity>()
                .HasOne(a => a.Basket)
                .WithOne(b => b.User)
                .HasForeignKey<BasketEntity>(b => b.UserId);

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
                .HasOne(ub =>ub.Basket)
                .WithMany(b => b.ProductBasketEntities)
                .HasForeignKey(bc => bc.BasketId);
            modelBuilder.Entity<ProductBasketEntity>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.ProductBasketEntities)
                .HasForeignKey(bc => bc.ProductId);
        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProviderCountryEntity> ProducerCountries { get; set; }
        public DbSet<BasketEntity> Baskets { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CurrenciesEntity> Currencies { get; set; }
        
    }
}
