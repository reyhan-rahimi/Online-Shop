using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        [Required]
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "متن نظر")]
        public string Text { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
