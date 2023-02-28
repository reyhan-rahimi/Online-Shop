using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Users> UsersTable { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Blog> blogs { get; set; }
    }
}