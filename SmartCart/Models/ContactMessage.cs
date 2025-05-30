using System;
using System.ComponentModel.DataAnnotations;
namespace SmartCart.Models
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime SentDate { get; set; }
    }


}