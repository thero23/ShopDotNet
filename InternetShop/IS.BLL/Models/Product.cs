using IS.DAL.Entities;

namespace IS.BLL.Models
{
    public class Product
    {

#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int QuantityInStock { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int ProviderCountryId { get; set; }
        public virtual ProviderCountry ProviderCountry { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithDiscount { get ; set; }
        public int Discount { get; set; }

#nullable enable
    }
}
