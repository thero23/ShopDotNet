using IS.DAL.Contexts.Configurations;
using IS.DAL.Entities;
using IS.DAL.Repositories;
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
         public DbSet<SubCategoryEntity> SubCategories { get; set; }
         public DbSet<ProductEntity> Products { get; set; }
         public DbSet<CategoryEntity> Categories { get; set; }
         public DbSet<ProviderCountryEntity> ProviderCountries { get; set; }
         public DbSet<BasketEntity> Baskets { get; set; }
         public DbSet<UserEntity> Users { get; set; }
         public DbSet<CurrencyEntity> Currencies { get; set; }
         public DbSet<OrderEntity> Orders { get; set; }
         public DbSet<OrderProductEntity> OrdersProducts { get; set; }
        public DbSet<ProductBasketEntity> ProductsBaskets { get; set; }
     //   public DbSet<ProductInBasketEntity> ProductInBasket { get; set; }
        public DbSet<BuyInOneClickEntity> BuyInOneClick { get; set; }
        public DbSet<WhishListEntity> WhishList { get; set; }
        public DbSet<ProductInOrderEntity> ProductInOrder { get; set; }
        public DbSet<CharacteristicsEntity> Characteristics { get; set; }
        public DbSet<AdditionalCharacteristicsEntity> AdditionalCharacteristics { get; set; }
        public DbSet<EqualsEntity> Equals { get; set; }
        public DbSet<ProductsCharacteristicEntity> ProductCharacteristics { get; set; }

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
                .HasKey(ub => new { ub.Id});
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
            /* modelBuilder.Entity<ProductInOrderEntity>()
                 .HasOne(op=> op.ProductEntity)
                 .WithMany(x=> x.ProductInOrderEntities)
                 .HasForeignKey(y=> y.ProductEntityId);*/

            modelBuilder.Entity<BasketEntity>().Property(x => x.Id).HasDefaultValue(Guid.NewGuid().ToString());
         
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
         
        }
    }
}
