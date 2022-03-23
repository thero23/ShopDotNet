using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
