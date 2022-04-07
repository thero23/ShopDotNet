using System.Collections.Generic;
using InternetShop.ViewModels.Product;
using IS.BLL.Models;

namespace InternetShop.ViewModels.Basket
{
    public class BasketViewModel
    {
#nullable disable
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }

#nullable enable
    }
}
