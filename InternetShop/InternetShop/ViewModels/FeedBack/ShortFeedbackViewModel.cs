using InternetShop.API.ViewModels.Product;
using InternetShop.Api.ViewModels.User;

namespace InternetShop.Api.ViewModels.FeedBack
{
    public class ShortFeedbackViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public UserViewModel User { get; set; }
        public string Message { get; set; }
        public int Rate { get; set; }
    }
}
