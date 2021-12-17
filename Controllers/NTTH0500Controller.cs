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
    public class NTTH0500Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public NTTH0500Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: NTTH0500
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTTH0500.ToListAsync());
        }

        // GET: NTTH0500/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTTH0500 = await _context.NTTH0500
                .FirstOrDefaultAsync(m => m.NTTHID == id);
            if (nTTH0500 == null)
            {
                return NotFound();
            }

            return View(nTTH0500);
        }

        // GET: NTTH0500/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTTH0500/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTTHID,NTTHName,NTTHGender")] NTTH0500 nTTH0500)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTTH0500);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTTH0500);
        }

        // GET: NTTH0500/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTTH0500 = await _context.NTTH0500.FindAsync(id);
            if (nTTH0500 == null)
            {
                return NotFound();
            }
            return View(nTTH0500);
        }

        // POST: NTTH0500/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTTHID,NTTHName,NTTHGender")] NTTH0500 nTTH0500)
        {
            if (id != nTTH0500.NTTHID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTTH0500);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTTH0500Exists(nTTH0500.NTTHID))
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
            return View(nTTH0500);
        }

        // GET: NTTH0500/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTTH0500 = await _context.NTTH0500
                .FirstOrDefaultAsync(m => m.NTTHID == id);
            if (nTTH0500 == null)
            {
                return NotFound();
            }

            return View(nTTH0500);
        }

        // POST: NTTH0500/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nTTH0500 = await _context.NTTH0500.FindAsync(id);
            _context.NTTH0500.Remove(nTTH0500);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTTH0500Exists(string id)
        {
            return _context.NTTH0500.Any(e => e.NTTHID == id);
        }
    }
}
