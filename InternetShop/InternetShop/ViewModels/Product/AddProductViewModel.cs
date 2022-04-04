namespace InternetShop.ViewModels.Product
{
    public class AddProductViewModel
    {
#nullable disable
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int QuantityInStock { get; set; }

        public int CurrencyId { get; set; }
        public int CategoryId { get; set; }

        public int ProviderCountryId { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }

#nullable enable
    }
}
