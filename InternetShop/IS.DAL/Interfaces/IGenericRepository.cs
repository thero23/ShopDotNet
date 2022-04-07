using System.Linq.Expressions;

namespace IS.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken ct);
        Task<TEntity?> GetById(int id, CancellationToken ct);
        Task<TEntity> Add(TEntity entity, CancellationToken ct);
        Task Delete(int id, CancellationToken ct);
        Task Delete(TEntity entity, CancellationToken ct);
        Task DeleteRange(IEnumerable<TEntity> entities, CancellationToken ct);
        Task<TEntity> Update(TEntity entity, CancellationToken ct);
        IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression);
    }
}
