using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Joyeria.Data;
using Joyeria.Models;
using Microsoft.AspNetCore.Authorization;

namespace Joyeria.Controllers
{
    [Authorize(Roles = "admin")]
    public class JewelleryTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JewelleryTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JewelleryTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.JewelleryTypes.ToListAsync());
        }

        // GET: JewelleryTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryType = await _context.JewelleryTypes
                .FirstOrDefaultAsync(m => m.JewelleryTypeID == id);
            if (jewelleryType == null)
            {
                return NotFound();
            }

            return View(jewelleryType);
        }

        // GET: JewelleryTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JewelleryTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JewelleryTypeID,JewelleryTypeName")] JewelleryType jewelleryType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jewelleryType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jewelleryType);
        }

        // GET: JewelleryTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryType = await _context.JewelleryTypes.FindAsync(id);
            if (jewelleryType == null)
            {
                return NotFound();
            }
            return View(jewelleryType);
        }

        // POST: JewelleryTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JewelleryTypeID,JewelleryTypeName")] JewelleryType jewelleryType)
        {
            if (id != jewelleryType.JewelleryTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jewelleryType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JewelleryTypeExists(jewelleryType.JewelleryTypeID))
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
            return View(jewelleryType);
        }

        // GET: JewelleryTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryType = await _context.JewelleryTypes
                .FirstOrDefaultAsync(m => m.JewelleryTypeID == id);
            if (jewelleryType == null)
            {
                return NotFound();
            }

            return View(jewelleryType);
        }

        // POST: JewelleryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jewelleryType = await _context.JewelleryTypes.FindAsync(id);
            _context.JewelleryTypes.Remove(jewelleryType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JewelleryTypeExists(int id)
        {
            return _context.JewelleryTypes.Any(e => e.JewelleryTypeID == id);
        }
    }
}
