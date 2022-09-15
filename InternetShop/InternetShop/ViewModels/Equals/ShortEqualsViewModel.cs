using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.Equals
{
    public class ShortEqualsViewModel
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
