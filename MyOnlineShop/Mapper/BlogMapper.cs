using MyOnlineShop.Models;
using MyOnlineShop.Models.ViewModel;

namespace MyOnlineShop.Mapper
{
    public static class BlogMapper
    {
        public static Blog ToDataModel(this BlogViweModel Blog)
        {
            return new Blog
            {
                BlogId = Blog.BlogId,
                Aouther = Blog.Aouther,
                Category = Blog.Category,
                CreateDate = Blog.CreateDate,
                Lable = Blog.Lable,
                Picture = Blog?.Picture?.FileName,
                SubTitle = Blog.SubTitle,
                Summary = Blog.Summary,
                Text = Blog.Text,
                Title = Blog.Title,
                View = Blog.View,
            };
        }
    }
}
