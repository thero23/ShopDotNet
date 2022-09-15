using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IS.DAL.Repositories
{
    public class CharacteristicRepository : GenericRepository<CharacteristicsEntity>, ICharacteristicRepository
    {
        public CharacteristicRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CharacteristicsEntity>> Get(IEnumerable<int> ids, CancellationToken cancellationToken)
        {
            var result = await _dbSet.AsNoTracking().Where(x=> ids.Contains(x.Id)).Include(x=> x.AdditionalCharacteristics).ToListAsync(cancellationToken);
            return result;
        }

        public override async Task<IEnumerable<CharacteristicsEntity>> GetAll(CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x => x.AdditionalCharacteristics).Include(x=> x.AdditionalCharacteristics).ToListAsync(ct);
            return result;
        }
    }
}
