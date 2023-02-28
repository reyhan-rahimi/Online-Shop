using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models.ViewModel
{
    public class BlogViweModel
    {

        public int BlogId { get; set; }
        [Required]
        [Display(Name = "عنوان بلاگ")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "توضیح کوتاه درمورد بلاگ")]
        public string SubTitle { get; set; }
        [Required]
        [Display(Name = "زمان ایجاد بلاگ")]
        public DateTime CreateDate { get; set; }
        [Required]
        [Display(Name = "متن بلاگ")]
        public string Text { get; set; }
        [Required]
        [Display(Name = "دسته بندی بلاگ")]
        public string Category { get; set; }
        [Required]
        [Display(Name = "برچسب های بلاگ")]
        public string Lable { get; set; }
        [Required]
        [Display(Name = "متن بلاگ")]
        public string Aouther { get; set; }
        [Required]
        [Display(Name = "تصویر بلاگ")]
        public IFormFile Picture { get; set; }
        [Required]
        [Display(Name = "خلاصه بلاگ")]
        public string Summary { get; set; }
        public int View { get; set; }
    }
}
