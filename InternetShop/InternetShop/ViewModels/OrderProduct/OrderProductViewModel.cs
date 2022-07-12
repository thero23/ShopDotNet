using InternetShop.Api.ViewModels.Order;
using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.OrderProduct
{
    public class OrderProductViewModel
    {
#nullable disable
        public int OrderId { get; set; }
        public virtual OrderViewModel Order { get; set; }
        public int ProductId { get; set; }
        public virtual ProductViewModel Product { get; set; }
#nullable enable
    }
}
