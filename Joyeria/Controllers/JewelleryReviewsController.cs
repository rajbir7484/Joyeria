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
    public class JewelleryReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JewelleryReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JewelleryReviews
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.JewelleryReviews.Include(j => j.Jewellery);
            return View(await applicationDbContext.ToListAsync());
        }

        
        // GET: JewelleryReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryReview = await _context.JewelleryReviews
                .Include(j => j.Jewellery)
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (jewelleryReview == null)
            {
                return NotFound();
            }

            return View(jewelleryReview);
        }

        // POST: JewelleryReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jewelleryReview = await _context.JewelleryReviews.FindAsync(id);
            _context.JewelleryReviews.Remove(jewelleryReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JewelleryReviewExists(int id)
        {
            return _context.JewelleryReviews.Any(e => e.ReviewID == id);
        }
    }
}
