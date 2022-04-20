namespace InternetShop.ViewModels.Product
{
    public class ProductForBasketViewModel
    {

#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityInBasket { get; set; }
        public int CurrencyId { get; set; }
        public int Price { get; set; }
        public int PriceWithDiscount { get; set; }
        public int Discount { get; set; }
#nullable enable
    }
}
