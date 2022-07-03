using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IS.BLL.Models
{
    public class ProductInOrder
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public string UserId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}