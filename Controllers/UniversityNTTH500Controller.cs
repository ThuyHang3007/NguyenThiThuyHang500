using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiThuyHang500.Models;

namespace NguyenThiThuyHang500.Controllers
{
    public class UniversityNTTH500Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public UniversityNTTH500Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: UniversityNTTH500
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityNTTH500.ToListAsync());
        }

        // GET: UniversityNTTH500/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNTTH500 = await _context.UniversityNTTH500
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTTH500 == null)
            {
                return NotFound();
            }

            return View(universityNTTH500);
        }

        // GET: UniversityNTTH500/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNTTH500/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNTTH500 universityNTTH500)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNTTH500);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNTTH500);
        }

        // GET: UniversityNTTH500/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNTTH500 = await _context.UniversityNTTH500.FindAsync(id);
            if (universityNTTH500 == null)
            {
                return NotFound();
            }
            return View(universityNTTH500);
        }

        // POST: UniversityNTTH500/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNTTH500 universityNTTH500)
        {
            if (id != universityNTTH500.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNTTH500);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNTTH500Exists(universityNTTH500.UniversityId))
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
            return View(universityNTTH500);
        }

        // GET: UniversityNTTH500/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNTTH500 = await _context.UniversityNTTH500
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTTH500 == null)
            {
                return NotFound();
            }

            return View(universityNTTH500);
        }

        // POST: UniversityNTTH500/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityNTTH500 = await _context.UniversityNTTH500.FindAsync(id);
            _context.UniversityNTTH500.Remove(universityNTTH500);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNTTH500Exists(string id)
        {
            return _context.UniversityNTTH500.Any(e => e.UniversityId == id);
        }
    }
}
