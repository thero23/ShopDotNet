using InternetShop.Api.ViewModels.Characteristics;
using System.Collections.Generic;

namespace InternetShop.API.ViewModels.Product
{
    public class ProductViewModel
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int QuantityInStock { get; set; }
        public int CurrencyId { get; set; }
        public int CategoryId { get; set; }
        public int ProviderCountryId { get; set; }
        public int Price { get; set; }
        public int PriceWithDiscount { get; set; }
        public int Discount { get; set; }
        public IEnumerable<CharacteristicsViewModel> Characteristics{ get; set; }
        public int Rate { get; set; }
#nullable enable
        public int SubCategoryId { get; set; }
        public HashSet<string> GeneralCharacteristicName { get; set; }
    }
}
