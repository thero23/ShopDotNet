using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface ISubCategoryRepository : IGenericRepository<SubCategoryEntity>
    {
        Task<IEnumerable<SubCategoryEntity>> GetAllAsync(int id, CancellationToken ct);
    }
}
