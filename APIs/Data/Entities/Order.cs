using Data.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime DateTime { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public virtual Product Product { get; set; }
    }
}
