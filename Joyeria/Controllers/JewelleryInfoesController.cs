using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Joyeria.Data;
using Joyeria.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Joyeria.Controllers
{
    [Authorize(Roles = "admin")]
    public class JewelleryInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public JewelleryInfoesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }


        // GET: JewelleryInfoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.JewelleryInfos.Include(j => j.GenderType).Include(j => j.JewelleryType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: JewelleryInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryInfo = await _context.JewelleryInfos
                .Include(j => j.GenderType)
                .Include(j => j.JewelleryType)
                .FirstOrDefaultAsync(m => m.JewelleryID == id);
            if (jewelleryInfo == null)
            {
                return NotFound();
            }

            return View(jewelleryInfo);
        }

        // GET: JewelleryInfoes/Create
        public IActionResult Create()
        {
            ViewData["GenderTypeID"] = new SelectList(_context.GenderTypes, "GenderTypeID", "GenderTypeName");
            ViewData["JewelleryTypeID"] = new SelectList(_context.JewelleryTypes, "JewelleryTypeID", "JewelleryTypeName");
            return View();
        }

        // POST: JewelleryInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JewelleryID,Title,Description,Weight,Price,File,GenderTypeID,JewelleryTypeID")] JewelleryInfo jewelleryInfo)
        {
            using (var memoryStream = new MemoryStream())
            {
                await jewelleryInfo.File.FormFile.CopyToAsync(memoryStream);

                string photoname = jewelleryInfo.File.FormFile.FileName;
                jewelleryInfo.Extension = Path.GetExtension(photoname);
                if (!".jpg.jpeg.png.gif.bmp".Contains(jewelleryInfo.Extension.ToLower()))
                {
                    ModelState.AddModelError("File.FormFile", "Invalid Format of Image Given.");
                }
                else
                {
                    ModelState.Remove("Extension");
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(jewelleryInfo);
                await _context.SaveChangesAsync();
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "photos");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                string filename = jewelleryInfo.JewelleryID + jewelleryInfo.Extension;
                var filePath = Path.Combine(uploadsRootFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await jewelleryInfo.File.FormFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenderTypeID"] = new SelectList(_context.GenderTypes, "GenderTypeID", "GenderTypeName", jewelleryInfo.GenderTypeID);
            ViewData["JewelleryTypeID"] = new SelectList(_context.JewelleryTypes, "JewelleryTypeID", "JewelleryTypeName", jewelleryInfo.JewelleryTypeID);
            return View(jewelleryInfo);
        }

        // GET: JewelleryInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryInfo = await _context.JewelleryInfos.FindAsync(id);
            if (jewelleryInfo == null)
            {
                return NotFound();
            }
            ViewData["GenderTypeID"] = new SelectList(_context.GenderTypes, "GenderTypeID", "GenderTypeName", jewelleryInfo.GenderTypeID);
            ViewData["JewelleryTypeID"] = new SelectList(_context.JewelleryTypes, "JewelleryTypeID", "JewelleryTypeName", jewelleryInfo.JewelleryTypeID);
            return View(jewelleryInfo);
        }

        // POST: JewelleryInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JewelleryID,Title,Description,Extension,Weight,Price,GenderTypeID,JewelleryTypeID")] JewelleryInfo jewelleryInfo)
        {
            if (id != jewelleryInfo.JewelleryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jewelleryInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JewelleryInfoExists(jewelleryInfo.JewelleryID))
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
            ViewData["GenderTypeID"] = new SelectList(_context.GenderTypes, "GenderTypeID", "GenderTypeName", jewelleryInfo.GenderTypeID);
            ViewData["JewelleryTypeID"] = new SelectList(_context.JewelleryTypes, "JewelleryTypeID", "JewelleryTypeName", jewelleryInfo.JewelleryTypeID);
            return View(jewelleryInfo);
        }

        // GET: JewelleryInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryInfo = await _context.JewelleryInfos
                .Include(j => j.GenderType)
                .Include(j => j.JewelleryType)
                .FirstOrDefaultAsync(m => m.JewelleryID == id);
            if (jewelleryInfo == null)
            {
                return NotFound();
            }

            return View(jewelleryInfo);
        }

        // POST: JewelleryInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jewelleryInfo = await _context.JewelleryInfos.FindAsync(id);
            _context.JewelleryInfos.Remove(jewelleryInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JewelleryInfoExists(int id)
        {
            return _context.JewelleryInfos.Any(e => e.JewelleryID == id);
        }
    }
}
