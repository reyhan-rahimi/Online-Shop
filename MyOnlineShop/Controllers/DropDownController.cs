using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data;

namespace MyOnlineShop.Controllers
{
    public class DropDownController : Controller
    {
        public readonly ApplicationDbContext Db;
        public DropDownController(ApplicationDbContext Db)
        {
            this.Db = Db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
