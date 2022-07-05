namespace IS.DAL.Entities
{
    public class BasketEntity
    {


#nullable disable
        public string UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public ICollection<ProductBasketEntity> ProductBasketEntities { get; set; }
        
#nullable enable
    }
}
