using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperHero.Data;

namespace Super_Hero.Controllers
{
    public class SuperHerosController2 : Controller
    {
        private readonly SuperHeroes _context;

        public SuperHerosController2(SuperHeroes context)
        {
            _context = context;
        }

        // GET: SuperHerosController2
        public async Task<IActionResult> Index()
        {
            return View(await _context.SuperHero.ToListAsync());
        }

        // GET: SuperHerosController2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superHeros = await _context.SuperHero
                .FirstOrDefaultAsync(m => m.Id == id);
            if (superHeros == null)
            {
                return NotFound();
            }

            return View(superHeros);
        }

        // GET: SuperHerosController2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuperHerosController2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Power")] SuperHeros superHeros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(superHeros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(superHeros);
        }

        // GET: SuperHerosController2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superHeros = await _context.SuperHero.FindAsync(id);
            if (superHeros == null)
            {
                return NotFound();
            }
            return View(superHeros);
        }

        // POST: SuperHerosController2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Power")] SuperHeros superHeros)
        {
            if (id != superHeros.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(superHeros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuperHerosExists(superHeros.Id))
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
            return View(superHeros);
        }

        // GET: SuperHerosController2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superHeros = await _context.SuperHero
                .FirstOrDefaultAsync(m => m.Id == id);
            if (superHeros == null)
            {
                return NotFound();
            }

            return View(superHeros);
        }

        // POST: SuperHerosController2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var superHeros = await _context.SuperHero.FindAsync(id);
            if (superHeros != null)
            {
                _context.SuperHero.Remove(superHeros);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuperHerosExists(int id)
        {
            return _context.SuperHero.Any(e => e.Id == id);
        }
    }
}
