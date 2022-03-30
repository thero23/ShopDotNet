using System.ComponentModel.DataAnnotations;

namespace IS.DAL.Entities
{
    public class CurrenciesEntity
    {
#nullable disable   
        public string Name { get; set; }
        public string Sign { get; set; }

      
#nullable enable
        public int? Id { get; set; }
        public ICollection<ProductEntity>? Products { get; set; }
    }
}
