﻿using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductInBasketRepository : IGenericRepository<ProductInBasketEntity>
    {
        Task<IEnumerable<ProductInBasketEntity>> GetById(int id, CancellationToken ct);
    }
}