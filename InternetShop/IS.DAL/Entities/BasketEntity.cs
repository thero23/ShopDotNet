namespace IS.DAL.Entities
{
    public class BasketEntity
    {


#nullable disable
        public int Id { get; set; }
        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<ProductBasketEntity> ProductBasketEntities { get; set; }
        
#nullable enable
    }
}
