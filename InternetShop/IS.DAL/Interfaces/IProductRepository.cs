using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductRepository: IGenericRepository<ProductEntity>
    {
        Task<IEnumerable<ProductEntity>> GetAllAsync(CancellationToken ct);
    }
}
