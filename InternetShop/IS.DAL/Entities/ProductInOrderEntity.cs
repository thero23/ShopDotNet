﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IS.DAL.Entities
{
    public class ProductInOrderEntity
    {
#nullable disable
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductEntityId { get; set; }
        [ForeignKey("ProductEntityId")]
        public virtual ProductEntity ProductEntity { get; set; }
        public int Count { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
