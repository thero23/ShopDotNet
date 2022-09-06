namespace IS.BLL.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual IEnumerable<GeneralSubCategoryName> SubCategories { get; set; }
    }
}
