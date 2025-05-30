using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace SmartCart.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }  // كل مستخدم يمكن أن يمتلك أكثر من سلة
    }
}




