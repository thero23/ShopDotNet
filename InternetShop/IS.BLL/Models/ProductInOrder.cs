namespace IS.BLL.Models
{
    public class ProductInOrder
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int UserDataId { get; set; }
        public UserData? UserData { get; set; }
    }
}