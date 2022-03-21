using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Contexts
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
            Database.Migrate();
        }
    }
}
