using InternetShop.Api.ViewModels.ProductBasket;
using InternetShop.Api.ViewModels.User;
using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.Basket
{
    public class BasketViewModel
    {
#nullable disable
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual UserViewModel User { get; set; }

#nullable enable
        public ICollection<ProductBasketViewModel>? ProductsBaskets { get; set; }
    }
}
