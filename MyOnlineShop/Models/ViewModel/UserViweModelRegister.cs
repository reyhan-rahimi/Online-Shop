using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models.ViewModel
{
    public class UserViweModelRegister
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "نام و نام خانوادگی*")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "پست الکترونیک*")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "رمز عبور*")]
        public string Password { get; set; }
        [Display(Name = "شماره کارت جهت مرجوع وجه*")]
        public string BancAccountNumber { get; set; }
    }
}
