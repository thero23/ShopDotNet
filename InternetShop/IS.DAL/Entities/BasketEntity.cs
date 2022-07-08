using System.ComponentModel.DataAnnotations;

namespace IS.DAL.Entities
{
    public class BasketEntity
    {
#nullable disable
        public string Id { get; set; }
        public string UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public ICollection<ProductBasketEntity> ProductBasketEntities { get; set; }
#nullable enable
    }
}
