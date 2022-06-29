namespace IS.DAL.Entities
{
    public class ProductInOrderEntity
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public UserEntity? User { get; set; }
    }
}
