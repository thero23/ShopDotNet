using InternetShop.Api.ViewModels.ProductBasket;
using InternetShop.Api.ViewModels.User;
using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.Basket
{
    public class AddBasketViewModel
    {
#nullable disable
        public string UserId { get; set; }
        public virtual UserViewModel User { get; set; }
        public ICollection<ProductBasketViewModel> ProductsBaskets { get; set; }
#nullable enable
    }
}
