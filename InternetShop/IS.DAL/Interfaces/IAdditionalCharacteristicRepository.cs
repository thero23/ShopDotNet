using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IAdditionalCharacteristicRepository : IGenericRepository<AdditionalCharacteristicsEntity>
    {
        Task<IEnumerable<AdditionalCharacteristicsEntity>> Get(IEnumerable<int> ids, CancellationToken ct);
    }
}
