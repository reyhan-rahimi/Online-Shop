using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data;
using MyOnlineShop.Models;
using System.Diagnostics;

namespace MyOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly ApplicationDbContext Db;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext Db)
        {
            _logger = logger;
            this.Db = Db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                Db.Contact.Add(contact);
                Db.SaveChanges();
            }
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Archive()
        {
            return View();
        }
        public IActionResult BlogPosts (){
            return View(Db.blogs.ToList());
        }
        public IActionResult BlogPost(int id)
        {
            return View(Db.blogs.Find(id));
        }
        public IActionResult Compare()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult ReChecking()
        {
            return View();
        }
        [HttpGet]
        //show all mobiles
        public IActionResult MobilePrudocts()
        {
            return View(Db.Mobiles.ToList());
        }
        public IActionResult MobilePrudoct(int id)
        {
            return View(Db.Mobiles.Find(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}