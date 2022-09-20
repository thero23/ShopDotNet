﻿namespace IS.BLL.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string AuthId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Message { get; set; }
        public int Rate { get; set; }
    }
}
