using InternetShop.Api.ViewModels.Basket;
using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.ProductBasket
{
    public class ProductBasketViewModel
    {
#nullable disable
        public int ProductId { get; set; }
        public virtual ProductViewModel Product { get; set; }

        public int BasketId { get; set; }
        public virtual BasketViewModel Basket { get; set; }
#nullable enable
    }
}
