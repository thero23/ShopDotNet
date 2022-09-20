namespace InternetShop.Api.ViewModels.FeedBack
{
    public class AddFeedBackViewModel
    {
        public int ProductId { get; set; }
        public string AuthId { get; set; }
        public int Rate { get; set; }
        public string Message { get; set; }
    }
}
