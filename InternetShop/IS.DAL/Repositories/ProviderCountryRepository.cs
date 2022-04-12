using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class ProviderCountryRepository:GenericRepository<ProviderCountryEntity>, IProviderCountryRepository
    {
        public ProviderCountryRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
