namespace InternetShop.Api.ViewModels.ProductInBasket
{
    public class UpdateProductInBasketViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public int Discount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public int Count { get; set; }
    }
}
