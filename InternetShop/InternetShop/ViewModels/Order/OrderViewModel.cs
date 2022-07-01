namespace InternetShop.Api.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
