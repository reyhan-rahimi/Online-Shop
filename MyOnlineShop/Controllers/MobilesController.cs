using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using MyOnlineShop.Data;
using MyOnlineShop.Models;
using MyOnlineShop.Models.ViewModel;
using MyOnlineShop.Mapper;

namespace MyOnlineShop.Controllers
{
    public class MobilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment env;

        public MobilesController(ApplicationDbContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _context = context;
            this.env = env;
        }

        // GET: Mobiles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mobiles.ToListAsync());
        }

        // GET: Mobiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobile = await _context.Mobiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mobile == null)
            {
                return NotFound();
            }

            return View(mobile);
        }

        // GET: Mobiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mobiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Garanty,Discribtor,Sale,Price,Picture,Colors,Dimensions,DateCreate,Weight,SIMcardsDescription,SpecialFeatures,NumberOfSimCards,Model,Chip,CPU,ProcessorType,CPUFrequency,GraphiteProcessore,InternalMemory,Ramsize,MemoryCardSupport,ScreenTechnology,size,Resulotion,PixelDensity,ScreenToBodyRatio,CommunicationNetworks,TwoG,ThreeG,FourG,CommunicationTechnology,CommunicationPortals,BluetoothVersion,BackCamera,PictureResolution,CameraAbility,Film,SelfiCamera,OperatingSystem,Sensor,BattreySpecifications,Review")] MobileViewModel viewModel)
        {
            var mobile = viewModel.ToDataModel();
            var file = viewModel.Picture;
            string wwwPath = env.WebRootPath;
            string contentPath = env.ContentRootPath;

            string path = Path.Combine(env.WebRootPath, "Uploaded");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fileName = Path.GetFileName(file.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                file.CopyTo(stream);
                ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
            }
            if (ModelState.IsValid)
            {
                _context.Add(mobile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mobile);
        }

        // GET: Mobiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobile = await _context.Mobiles.FindAsync(id);
            if (mobile == null)
            {
                return NotFound();
            }
            return View(mobile);
        }

        // POST: Mobiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Garanty,Discribtor,Sale,Price,Picture,Colors,Dimensions,DateCreate,Weight,SIMcardsDescription,SpecialFeatures,NumberOfSimCards,Model,Chip,CPU,ProcessorType,CPUFrequency,GraphiteProcessore,InternalMemory,Ramsize,MemoryCardSupport,ScreenTechnology,size,Resulotion,PixelDensity,ScreenToBodyRatio,CommunicationNetworks,TwoG,ThreeG,FourG,CommunicationTechnology,CommunicationPortals,BluetoothVersion,BackCamera,PictureResolution,CameraAbility,Film,SelfiCamera,OperatingSystem,Sensor,BattreySpecifications")] Mobile mobile)
        {
            if (id != mobile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mobile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobileExists(mobile.Id))
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
            return View(mobile);
        }

        // GET: Mobiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobile = await _context.Mobiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mobile == null)
            {
                return NotFound();
            }

            return View(mobile);
        }

        // POST: Mobiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mobile = await _context.Mobiles.FindAsync(id);
            _context.Mobiles.Remove(mobile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobileExists(int id)
        {
            return _context.Mobiles.Any(e => e.Id == id);
        }
    }
}
