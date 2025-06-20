﻿using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }




}
