﻿using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductInOrderService: IGenericService<ProductInOrder>
    {
        Task<IEnumerable<ProductInOrder>> Post(User userData, CancellationToken ct);
    }
}
