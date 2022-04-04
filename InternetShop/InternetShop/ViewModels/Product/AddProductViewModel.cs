using System.ComponentModel.DataAnnotations;

namespace InternetShop.ViewModels.Product
{
    public class AddProductViewModel
    {
#nullable disable
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int QuantityInStock { get; set; }
        public int CurrencyId { get; set; }
        public int CategoryId { get; set; }

        public int ProviderCountryId { get; set; }
        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Price { get; set; }
        [Range(0, 100, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Discount { get; set; }

#nullable enable
    }
}
