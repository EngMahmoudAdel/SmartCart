using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models
{
    public class Order
    {
 
            [Key]
            public int Id { get; set; }

            [Required]
            public string UserId { get; set; }  // مفتاح خارجي يشير إلى المستخدم
            public string? Address { get; set; } // عنوان المستخدم في هذا الطلب
            public string? Phone { get; set; } // عنوان المستخدم في هذا الطلب



            public ApplicationUser User { get; set; }  // العلاقة مع ApplicationUser

            public DateTime OrderDate { get; set; } = DateTime.Now;

            [Required]
            public decimal TotalAmount { get; set; }

            public ICollection<OrderItem> OrderItems { get; set; }  // كل طلب يحتوي على عناصر طلب

            // إضافة علاقة مع Payment
            public Payment Payment { get; set; }


    }


}



