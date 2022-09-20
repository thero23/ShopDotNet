namespace IS.DAL.Entities
{
    public class FeedbackEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public UserEntity User { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public string Message { get; set; }
        public int Rate { get; set; }
    }
}
