using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models
{
    public class OrderItem
    {
            [Key]
            public int Id { get; set; }

            [Required]
            public int OrderId { get; set; }
            public Order Order { get; set; }

            [Required]
            public int ProductId { get; set; }
            public Product Product { get; set; }

            [Required, Range(1, 100)]
            public int Quantity { get; set; }

            [Required, Range(0, 10000)]
            public decimal Price { get; set; }
        }

    }

