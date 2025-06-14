﻿using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models
{
        public class CartItem
        {
            [Key]
            public int Id { get; set; }



            [Required]
            public int CartId { get; set; }
            public Cart Cart { get; set; }

            [Required]
            public int ProductId { get; set; }
            public Product Product { get; set; }

            [Required, Range(1, 100)]
            public int Quantity { get; set; }
        }
}
