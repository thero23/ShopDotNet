using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.Equals
{
    public class EqualsViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public virtual ProductViewModel Product { get; set; }
    }
}
