using InternetShop.Api.ViewModels.User;
using InternetShop.API.ViewModels.Product;

namespace InternetShop.Api.ViewModels.FeedBack
{
    public class FeedBackViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public UserViewModel User { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        public string Message { get; set; }
        public int Rate { get; set; }
    }
}
