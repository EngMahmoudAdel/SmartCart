using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCart.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }

        public string? ImagePath { get; set; }  // هذا سيخزن مسار الصورة

        [Required]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }


}
