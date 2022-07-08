﻿using InternetShop.Api.ViewModels.Basket;
using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.ProductBasket
{
    public class UpdateProductBasketViewModel
    {
#nullable disable
        public int ProductId { get; set; }
        public virtual ProductViewModel Product { get; set; }

        public string BasketId { get; set; }
        public int Count { get; set; }
#nullable enable
    }
}
