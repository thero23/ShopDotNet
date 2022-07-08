using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.ProductBasket
{
    public class ShortProductBasketViewModel
    {
#nullable disable
        public int ProductId { get; set; }
        public virtual ProductViewModel Product { get; set; }
        public int Count { get; set; }
        public string BasketId { get; set; }
#nullable enable
    }
}
