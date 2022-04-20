using System.ComponentModel.DataAnnotations;

namespace InternetShop.ViewModels.Basket
{
    public class AddProductIntoBasketViewModel
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "The field {0} should be greater then {0}")]
        public int Quantity { get; set; }

    }
}
