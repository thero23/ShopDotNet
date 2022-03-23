using System.ComponentModel.DataAnnotations;

namespace InternetShop.ViewModels.Category
{
    public class AddCategoryViewModel
    {
        [MinLength(5)]
        public string Name { get; set; }
    }
}
