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
    public class MovimientoController : Controller
    {
        private readonly DataContext _context;

        public MovimientoController(DataContext context)
        {
            _context = context;
        }

        // GET: Movimiento
        public async Task<IActionResult> Index()
        {
              return View(await _context.Movimiento.ToListAsync());
        }

        // GET: Movimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movimiento == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .FirstOrDefaultAsync(m => m.MovimientoId == id);
            if (movimiento == null)
            {
                return NotFound();
            }

            return View(movimiento);
        }

        // GET: Movimiento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovimientoId,Tipo,Monto,Concepto,FechaDeMovimiento,Status")] Movimiento movimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movimiento);
        }

        // GET: Movimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Movimiento == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento.FindAsync(id);
            if (movimiento == null)
            {
                return NotFound();
            }
            return View(movimiento);
        }

        // POST: Movimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovimientoId,Tipo,Monto,Concepto,FechaDeMovimiento,Status")] Movimiento movimiento)
        {
            if (id != movimiento.MovimientoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovimientoExists(movimiento.MovimientoId))
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
            return View(movimiento);
        }

        // GET: Movimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movimiento == null)
            {
                return NotFound();
            }

            var movimiento = await _context.Movimiento
                .FirstOrDefaultAsync(m => m.MovimientoId == id);
            if (movimiento == null)
            {
                return NotFound();
            }

            return View(movimiento);
        }

        // POST: Movimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movimiento == null)
            {
                return Problem("Entity set 'DataContext.Movimiento'  is null.");
            }
            var movimiento = await _context.Movimiento.FindAsync(id);
            if (movimiento != null)
            {
                _context.Movimiento.Remove(movimiento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovimientoExists(int id)
        {
          return _context.Movimiento.Any(e => e.MovimientoId == id);
        }
    }
}
