using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "پست الکترونیک")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "کد ملی")]
        public int NationalNumber { get; set; }
        [Display(Name = "شماره تلفن همراه")]
        public string PhoneNumber { get; set; }
        [Display(Name = "شماره تلفن ثابت")]
        public string TelPhoneNummber { get; set; }
        [Display(Name = "تاریخ تولد")]
        public DateTime BirthDay { get; set; }
        [Display(Name = "شماره کارت جهت مرجوع وجه")]
        public string BancAccountNumber { get; set; }
    }
}
