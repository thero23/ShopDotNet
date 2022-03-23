using IS.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProviderCountryEntity> ProducerCountries { get; set; }
    }
}
