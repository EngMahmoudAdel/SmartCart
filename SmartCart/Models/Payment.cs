using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models
{
    
        public class Payment
        {
            public int Id { get; set; }

            [Required]
            public int OrderId { get; set; }
            public Order Order { get; set; }

            [Required, StringLength(50)]
            public string Method { get; set; }

            [Required, StringLength(20)]
            public string Status { get; set; }

            [Required, Range(0, 10000)]
            public decimal Amount { get; set; }

            public DateTime Date { get; set; }
        }


    }

