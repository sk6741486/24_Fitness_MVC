using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _24_Fitness_MVC.Data;
using _24_Fitness_MVC.Models;

namespace _24_Fitness_MVC.Controllers
{
    public class CenterDetailsController : Controller
    {
        private readonly DatabaseContext _context;

        public CenterDetailsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: CenterDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.CenterDetail.ToListAsync());
        }

        // GET: CenterDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centerDetail = await _context.CenterDetail
                .FirstOrDefaultAsync(m => m.Id == id);
            if (centerDetail == null)
            {
                return NotFound();
            }

            return View(centerDetail);
        }

        // GET: CenterDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CenterDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CenterName,Club_Id,Location,Phone,Open_Hours,Activitie")] CenterDetail centerDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(centerDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(centerDetail);
        }

        // GET: CenterDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centerDetail = await _context.CenterDetail.FindAsync(id);
            if (centerDetail == null)
            {
                return NotFound();
            }
            return View(centerDetail);
        }

        // POST: CenterDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CenterName,Club_Id,Location,Phone,Open_Hours,Activitie")] CenterDetail centerDetail)
        {
            if (id != centerDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(centerDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CenterDetailExists(centerDetail.Id))
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
            return View(centerDetail);
        }

        // GET: CenterDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centerDetail = await _context.CenterDetail
                .FirstOrDefaultAsync(m => m.Id == id);
            if (centerDetail == null)
            {
                return NotFound();
            }

            return View(centerDetail);
        }

        // POST: CenterDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var centerDetail = await _context.CenterDetail.FindAsync(id);
            _context.CenterDetail.Remove(centerDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CenterDetailExists(int id)
        {
            return _context.CenterDetail.Any(e => e.Id == id);
        }
    }
}
