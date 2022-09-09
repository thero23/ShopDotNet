using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class CharacteristicRepository : GenericRepository<CharacteristicsEntity>, ICharacteristicRepository
    {
        public CharacteristicRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<CharacteristicsEntity>> GetAll(CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x => x.AdditionalCharacteristics).ToListAsync(ct);
            return result;
        }
    }
}
