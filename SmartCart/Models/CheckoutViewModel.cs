using System.ComponentModel.DataAnnotations;

namespace SmartCart.Models.ViewModels
{
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }
    }
}