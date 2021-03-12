using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; } 
        [Required]
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
    }
}