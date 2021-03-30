using Joyeria.Data;
using Joyeria.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Joyeria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.JewelleryTypes.OrderBy(x => Guid.NewGuid()).ToListAsync());
        }

        public async Task<IActionResult> AllGenderTypes()
        {
            return View(await _context.GenderTypes.OrderBy(x => Guid.NewGuid()).ToListAsync());
        }

        public async Task<IActionResult> ViewJewelleryByType(int? id)
        {
            var applicationDbContext = _context.JewelleryInfos
                .Include( j => j.GenderType)
            .Include(j => j.JewelleryType).Where(m => m.JewelleryTypeID == id);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> ViewJewelleryByGender(int? id)
        {
            var applicationDbContext = _context.JewelleryInfos
                .Include(j => j.GenderType)
            .Include(j => j.JewelleryType).Where(m => m.GenderTypeID == id);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> ViewJewelleryDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelleryInfo = await _context.JewelleryInfos
                .Include(j => j.GenderType)
                .Include(j => j.JewelleryType)
                .Include(j => j.JewelleryReviews)
                .FirstOrDefaultAsync(m => m.JewelleryID == id);
            if (jewelleryInfo == null)
            {
                return NotFound();
            }

            return View(jewelleryInfo);
        }

        public async Task<IActionResult> ViewAllJewellery()
        {
            var applicationDbContext = _context.JewelleryInfos.Include(j => j.GenderType).Include(j => j.JewelleryType);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize]
        public IActionResult AddReview(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var jewelleryInfo = _context.JewelleryInfos
                .Include(j => j.GenderType)
                .Include(j => j.JewelleryType)
                .FirstOrDefault(m => m.JewelleryID == id);
            if (jewelleryInfo == null)
            {
                return NotFound();
            }

            ViewData["JewelleryID"] = jewelleryInfo.JewelleryID;
            ViewData["JewelleryTitle"] = jewelleryInfo.Title;
            return View();
        }

        // POST: JewelleryReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview([Bind("ReviewID,ReviewText,JewelleryID")] JewelleryReview jewelleryReview)
        {
            ModelState.Remove("ReviewerName");
            ModelState.Remove("ReviewDate");
            if (ModelState.IsValid)
            {
                jewelleryReview.ReviewerName = _userManager.GetUserName(this.User);
                jewelleryReview.ReviewDate = DateTime.Now;
                _context.Add(jewelleryReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JewelleryID"] = jewelleryReview.JewelleryID;
            return View(jewelleryReview);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
