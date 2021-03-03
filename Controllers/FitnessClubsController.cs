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
    public class FitnessClubsController : Controller
    {
        private readonly DatabaseContext _context;

        public FitnessClubsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: FitnessClubs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FitnessClub.ToListAsync());
        }

        // GET: FitnessClubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessClub = await _context.FitnessClub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fitnessClub == null)
            {
                return NotFound();
            }

            return View(fitnessClub);
        }

        // GET: FitnessClubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FitnessClubs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Club_Name,Club_Email,Club_Phone,Gender_Type,Package_Id")] FitnessClub fitnessClub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fitnessClub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fitnessClub);
        }

        // GET: FitnessClubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessClub = await _context.FitnessClub.FindAsync(id);
            if (fitnessClub == null)
            {
                return NotFound();
            }
            return View(fitnessClub);
        }

        // POST: FitnessClubs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Club_Name,Club_Email,Club_Phone,Gender_Type,Package_Id")] FitnessClub fitnessClub)
        {
            if (id != fitnessClub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fitnessClub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FitnessClubExists(fitnessClub.Id))
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
            return View(fitnessClub);
        }

        // GET: FitnessClubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessClub = await _context.FitnessClub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fitnessClub == null)
            {
                return NotFound();
            }

            return View(fitnessClub);
        }

        // POST: FitnessClubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fitnessClub = await _context.FitnessClub.FindAsync(id);
            _context.FitnessClub.Remove(fitnessClub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FitnessClubExists(int id)
        {
            return _context.FitnessClub.Any(e => e.Id == id);
        }
    }
}
