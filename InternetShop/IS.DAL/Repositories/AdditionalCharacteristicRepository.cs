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

        public Task<IEnumerable<AdditionalCharacteristicsEntity>> Get(IEnumerable<int> ids, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
