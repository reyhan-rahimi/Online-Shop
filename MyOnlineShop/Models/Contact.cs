using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "شماره تماس")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "موضوع پیام")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "متن پیام")]
        public string Text { get; set; }
    }
}
