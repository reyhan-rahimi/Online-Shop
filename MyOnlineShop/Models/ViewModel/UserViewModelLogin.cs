
using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
       
        [Required]
        [Display(Name = "پست الکترونیک*")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "رمز عبور*")]
        public string Password { get; set; }
    }
}

