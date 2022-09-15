using InternetShop.Api.ViewModels.Characteristics;

namespace InternetShop.Api.ViewModels.ProductsCharacteristic
{
    public class ProductsCharacteristicViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        // public Product Product { get; set; }

 //       public int CharacteristicsId { get; set; }
        public CharacteristicsViewModel Characteristics { get; set; }
    }
}
