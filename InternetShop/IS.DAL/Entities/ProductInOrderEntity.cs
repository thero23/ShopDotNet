namespace IS.DAL.Entities
{
    public class ProductInOrderEntity
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int UserDataId { get; set; }
        public UserDataEntity? UserData { get; set; }
    }
}
