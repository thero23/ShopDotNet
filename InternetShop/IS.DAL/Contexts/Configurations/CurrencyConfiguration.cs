using IS.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IS.DAL.Contexts.Configurations
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<CurrenciesEntity>
    {
        public void Configure(EntityTypeBuilder<CurrenciesEntity> builder)
        {
            builder.HasData(
                new CurrenciesEntity
                {
                    Id = 1,
                    Name = "BYN",
                    Sign = "BYN",
                }, new CurrenciesEntity
                {
                    Id = 2,
                    Name = "USD",
                    Sign = "$",
                }, new CurrenciesEntity
                {
                    Id = 3,
                    Name = "EUR",
                    Sign = "€",
                });
        }
    }
}
