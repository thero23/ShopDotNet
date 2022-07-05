using InternetShop.Api.ViewModels.ProductBasket;
using InternetShop.Api.ViewModels.User;
using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.Basket
{
    public class UpdateBasketViewModel
    {
#nullable disable
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual UserViewModel User { get; set; }
        public ICollection<ProductBasketViewModel> ProductsBaskets { get; set; }
#nullable enable
    }
}
