namespace IS.DAL.Entities
{
    public class SubCategoryEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public ICollection<GeneralSubCategoryNameEntity> SubCategories { get; set; }
    }
}
