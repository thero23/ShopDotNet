﻿namespace IS.DAL.Entities
{
    public class ProductEntity
    {
#nullable disable
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
   
      

#nullable enable
        public int Id { get; set; }

    
        public int QuantityInStock { get; set; }
        public int Discount { get; set; }
        
        public int? CurrencyId { get; set; }
        public virtual CurrenciesEntity? Currency { get; set; }
        public int? CategoryId { get; set; }
        public virtual CategoryEntity? Category { get; set; }

        public ICollection<ProductBasketEntity>? ProductBasketEntities { get; set; }
        public ICollection<OrderProductEntity>? OrderProductEntities { get; set; }
        public int? ProviderCountryId { get; set; }
        public virtual ProviderCountryEntity? ProviderCountry { get; set; }
        
      

    }
}
