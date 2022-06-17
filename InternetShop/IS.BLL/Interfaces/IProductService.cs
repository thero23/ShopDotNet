﻿using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductService:IGenericService<Product>
    {
        Task<IEnumerable<Product>> GetProductWithCategory(int categoryId, CancellationToken ct);
    }
}
