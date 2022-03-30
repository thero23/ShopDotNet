namespace IS.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken ct);
        Task<TEntity?> GetById(int id, CancellationToken ct);
        Task<TEntity> Add(TEntity entity, CancellationToken ct);
        ValueTask Delete(int id, CancellationToken ct);
        Task<TEntity> Update(TEntity entity, CancellationToken ct);
    }
}
