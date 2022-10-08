using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FINMUE.Models;

namespace FINMUE.Controllers
{
    public class CasaController : Controller
    {
        private readonly DataContext _context;

        public CasaController(DataContext context)
        {
            _context = context;
        }

        // GET: Casa
        public async Task<IActionResult> Index()
        {
              return View(await _context.Casa.ToListAsync());
        }

        // GET: Casa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Casa == null)
            {
                return NotFound();
            }

            var casa = await _context.Casa
                .FirstOrDefaultAsync(m => m.CasaId == id);
            if (casa == null)
            {
                return NotFound();
            }

            return View(casa);
        }

        // GET: Casa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CasaId,NumeroDeCasa,MetrosCuadrados,InmuebleId")] Casa casa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(casa);
        }

        // GET: Casa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Casa == null)
            {
                return NotFound();
            }

            var casa = await _context.Casa.FindAsync(id);
            if (casa == null)
            {
                return NotFound();
            }
            return View(casa);
        }

        // POST: Casa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CasaId,NumeroDeCasa,MetrosCuadrados,InmuebleId")] Casa casa)
        {
            if (id != casa.CasaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasaExists(casa.CasaId))
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
            return View(casa);
        }

        // GET: Casa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Casa == null)
            {
                return NotFound();
            }

            var casa = await _context.Casa
                .FirstOrDefaultAsync(m => m.CasaId == id);
            if (casa == null)
            {
                return NotFound();
            }

            return View(casa);
        }

        // POST: Casa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Casa == null)
            {
                return Problem("Entity set 'DataContext.Casa'  is null.");
            }
            var casa = await _context.Casa.FindAsync(id);
            if (casa != null)
            {
                _context.Casa.Remove(casa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasaExists(int id)
        {
          return _context.Casa.Any(e => e.CasaId == id);
        }
    }
}
