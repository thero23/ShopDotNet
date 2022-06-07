using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class BuyInOneClickRepository : GenericRepository<BuyInOneClickEntity>, IBuyInOneClickRepository
    {
        public BuyInOneClickRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
