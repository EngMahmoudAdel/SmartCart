using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models
{
    public class Cart
    {

      
            [Key]
            public int Id { get; set; }

            [Required]
            public string UserId { get; set; }  // مفتاح خارجي يشير إلى المستخدم
            public ApplicationUser User { get; set; }  // العلاقة مع ApplicationUser


            public ICollection<CartItem> CartItems { get; set; }
    }

 }

