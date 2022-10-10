using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LegacyView.Data;
using LegacyView.Models;

namespace LegacyView.Controllers
{
    public class DVDsController : Controller
    {
        private readonly LegacyViewContext _context;

        public DVDsController(LegacyViewContext context)
        {
            _context = context;
        }

        // GET: DVDs
        public async Task<IActionResult> Index(string searchString) //adding searchString as parameter
        {
            var dvds = from d in _context.DVD
                         select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                //querying for dvd matching searchString
                dvds = dvds.Where(s => s.DVDName.Contains(searchString)); //Lambda Expression
            }
            return View(await dvds.ToListAsync());
        }

        // GET: DVDs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVD = await _context.DVD
                .FirstOrDefaultAsync(m => m.DVDId == id);
            if (dVD == null)
            {
                return NotFound();
            }

            return View(dVD);
        }

        // GET: DVDs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DVDs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DVDId,DVDName,DVDGenre,DVDDescription,DVDPrice,ReleaseDate,DVDCustomerReview")] DVD dVD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dVD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dVD);
        }

        // GET: DVDs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVD = await _context.DVD.FindAsync(id);
            if (dVD == null)
            {
                return NotFound();
            }
            return View(dVD);
        }

        // POST: DVDs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DVDId,DVDName,DVDGenre,DVDDescription,DVDPrice,ReleaseDate,DVDCustomerReview")] DVD dVD)
        {
            if (id != dVD.DVDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dVD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DVDExists(dVD.DVDId))
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
            return View(dVD);
        }

        // GET: DVDs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVD = await _context.DVD
                .FirstOrDefaultAsync(m => m.DVDId == id);
            if (dVD == null)
            {
                return NotFound();
            }

            return View(dVD);
        }

        // POST: DVDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dVD = await _context.DVD.FindAsync(id);
            _context.DVD.Remove(dVD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DVDExists(int id)
        {
            return _context.DVD.Any(e => e.DVDId == id);
        }
    }
}
