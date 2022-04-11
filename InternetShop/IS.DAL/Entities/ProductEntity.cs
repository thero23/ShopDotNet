using System.ComponentModel.DataAnnotations;

namespace IS.DAL.Entities
{
    public class ProductEntity
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int QuantityInStock { get; set; }

        public int CurrencyId { get; set; }
        public virtual CurrencyEntity Currency { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }


        public int ProviderCountryId { get; set; }
        public virtual ProviderCountryEntity ProviderCountry { get; set; }

        public int Discount { get; set; }

        public decimal Price { get; set; }

#nullable enable
        public ICollection<ProductBasketEntity>? ProductBasketEntities { get; set; }
        public ICollection<OrderProductEntity>? OrderProductEntities { get; set; }

        public ICollection<ProductGenericCharacteristic>? ProductGenericCharacteristics { get; set; }

    }
}
