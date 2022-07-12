using InternetShop.Api.ViewModels.OrderProduct;
using InternetShop.Api.ViewModels.User;
using System;
using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.Order
{
    public class OrderViewModel
    {
#nullable disable
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual UserViewModel User { get; set; }
        public string UserId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreatedAt { get; set; }
#nullable enable
        public ICollection<OrderProductViewModel>? OrderProduct { get; set; }
    }
}
