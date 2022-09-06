using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductRepository: IGenericRepository<ProductEntity>
    {
        Task<IEnumerable<ProductEntity>> GetProductWithCategory(int categoryId, CancellationToken ct);
        Task<IEnumerable<ProductEntity>> GetProductsBySubCategory(int subCategoryId, CancellationToken ct);
        Task<IEnumerable<ProductEntity>> GetProductFromwhishList(IEnumerable<int> ids, CancellationToken ct);
        Task<ProductEntity> GetById (int id, CancellationToken ct);
    }
}
