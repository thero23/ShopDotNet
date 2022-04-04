namespace InternetShop.ViewModels.Product
{
    public class ShortProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int Discount { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithDiscount { get; set; }
    }
}
