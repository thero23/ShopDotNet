using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class AdditionalCharacteristicRepository : GenericRepository<AdditionalCharacteristicsEntity>, IAdditionalCharacteristicRepository
    {
        public AdditionalCharacteristicRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<AdditionalCharacteristicsEntity>> Get(IEnumerable<int> ids, CancellationToken ct)
        {
            throw new NotImplementedException();
         //   var result = await _dbSet.AsNoTracking().Where(x=> x.)
        }
    }
}
