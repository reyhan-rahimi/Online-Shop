#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Data;
using MyOnlineShop.Models;
using MyOnlineShop.Models.ViewModel;

namespace MyOnlineShop.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsersTable.ToListAsync());
        }


        public IActionResult Profile(int found)
        {
            Users users=TempData["ID"] as Users;
            var user = _context.UsersTable.Where(x=>x.Id==users.Id).Select(x=>x);
            return View(user);
           
        }
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult Addresses()
        {
            return View();
        }
        public IActionResult Favorites()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var found = _context.UsersTable.Where(x => x.Email == userViewModel.Email && x.Password==userViewModel.Password).FirstOrDefault();

                if (found != null)
                {
                    TempData["ID"] =found;
                    return RedirectToAction("Profile");
                    
                }
                else
                {
                    return RedirectToAction("Index");
                }
                
            }
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Users users)
        {
            //Users user = new Users();
            if (ModelState.IsValid)
            {
                //user.Name = userViweModelRegister.Name;
                //user.Email = userViweModelRegister.Email;
                //user.Password=userViweModelRegister.Password;
                _context.UsersTable.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }


        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.UsersTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // GET: Users/Create
       
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.UsersTable.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Password,NationalNumber,PhoneNumber,TelPhoneNummber,BirthDay,BancAccountNumber")] Users users)
        {
            if (id != users.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.UsersTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.UsersTable.FindAsync(id);
            _context.UsersTable.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.UsersTable.Any(e => e.Id == id);
        }
    }
}
