namespace IS.DAL.Entities
{
    public class ProductInOrderEntity
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressToDelivery { get; set; }
    }
}
