using IS.DAL.Entities;
using System.Linq.Expressions;

namespace IS.DAL.Interfaces
{
    public interface IBasketRepository:IGenericRepository<BasketEntity>
    {
        IQueryable<BasketEntity> GetByCondition(Expression<Func<BasketEntity, bool>> expression);
    }
}
