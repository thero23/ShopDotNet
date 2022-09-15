using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface ICharacteristicRepository : IGenericRepository<CharacteristicsEntity>
    {
        Task<IEnumerable<CharacteristicsEntity>> GetAll(CancellationToken cancellationToken);
        Task<IEnumerable<CharacteristicsEntity>> Get(IEnumerable<int> ids, CancellationToken cancellationToken);
    }
}
