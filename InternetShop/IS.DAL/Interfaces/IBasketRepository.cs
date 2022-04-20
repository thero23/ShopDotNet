using IS.DAL.Entities;
using System.Linq.Expressions;

namespace IS.DAL.Interfaces
{
    public interface IBasketRepository:IGenericRepository<BasketEntity>
    {
        Task<BasketEntity> GetByCondition(string id);
    }
}
