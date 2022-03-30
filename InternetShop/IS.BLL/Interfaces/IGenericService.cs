namespace IS.BLL.Interfaces
{
    public interface IGenericService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll(CancellationToken ct);
        Task<TEntity?> GetById(int id, CancellationToken ct);
        Task<TEntity> Add(TEntity entity, CancellationToken ct);
        ValueTask Delete(int id, CancellationToken ct);
        Task<TEntity> Update(TEntity entity, CancellationToken ct);
    }
}
