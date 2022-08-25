namespace IS.DAL.Entities
{
    public class SubCategoryEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
#nullable disable
        public string Name { get; set; }
#nullable enable
    }
}
