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
    public class GenderTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenderTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GenderTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.GenderTypes.ToListAsync());
        }

        // GET: GenderTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderType = await _context.GenderTypes
                .FirstOrDefaultAsync(m => m.GenderTypeID == id);
            if (genderType == null)
            {
                return NotFound();
            }

            return View(genderType);
        }

        // GET: GenderTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenderTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenderTypeID,GenderTypeName")] GenderType genderType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genderType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genderType);
        }

        // GET: GenderTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderType = await _context.GenderTypes.FindAsync(id);
            if (genderType == null)
            {
                return NotFound();
            }
            return View(genderType);
        }

        // POST: GenderTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenderTypeID,GenderTypeName")] GenderType genderType)
        {
            if (id != genderType.GenderTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genderType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenderTypeExists(genderType.GenderTypeID))
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
            return View(genderType);
        }

        // GET: GenderTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderType = await _context.GenderTypes
                .FirstOrDefaultAsync(m => m.GenderTypeID == id);
            if (genderType == null)
            {
                return NotFound();
            }

            return View(genderType);
        }

        // POST: GenderTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genderType = await _context.GenderTypes.FindAsync(id);
            _context.GenderTypes.Remove(genderType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenderTypeExists(int id)
        {
            return _context.GenderTypes.Any(e => e.GenderTypeID == id);
        }
    }
}
