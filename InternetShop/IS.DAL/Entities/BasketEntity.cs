namespace IS.DAL.Entities
{
    public class BasketEntity
    {
       

#nullable disable
        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }
        public ICollection<ProductBasketEntity> ProductBasketEntities { get; set; }
#nullable enable
        public int Id { get; set; }
    }
}
