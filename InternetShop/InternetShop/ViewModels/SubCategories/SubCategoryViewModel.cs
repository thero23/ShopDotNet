using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.SubCategories
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual IEnumerable<GeneralSubCategoryNameViewModel> SubCategories { get; set; }
    }
}
