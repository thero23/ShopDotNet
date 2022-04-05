using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
