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
                    Name = "BYN",
                    Sign = "BYN",
                }, new CurrenciesEntity
                {

                    Name = "USD",
                    Sign = "$",
                }, new CurrenciesEntity
                {
                    Name = "EUR",
                    Sign = "€",
                });
        }
    }
}
