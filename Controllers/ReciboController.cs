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
    public class ReciboController : Controller
    {
        private readonly DataContext _context;

        public ReciboController(DataContext context)
        {
            _context = context;
        }

        // GET: Recibo
        public async Task<IActionResult> Index()
        {
              return View(await _context.Recibo.ToListAsync());
        }

        // GET: Recibo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Recibo == null)
            {
                return NotFound();
            }

            var recibo = await _context.Recibo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recibo == null)
            {
                return NotFound();
            }

            return View(recibo);
        }

        // GET: Recibo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recibo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ValorUnicoRecibo,FechaEmision,Importe,Concepto,CargoAgua,CargoElectricidad,CargoTelefono,CargoGas,Status,InmuebleId")] Recibo recibo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recibo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recibo);
        }

        // GET: Recibo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Recibo == null)
            {
                return NotFound();
            }

            var recibo = await _context.Recibo.FindAsync(id);
            if (recibo == null)
            {
                return NotFound();
            }
            return View(recibo);
        }

        // POST: Recibo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ValorUnicoRecibo,FechaEmision,Importe,Concepto,CargoAgua,CargoElectricidad,CargoTelefono,CargoGas,Status,InmuebleId")] Recibo recibo)
        {
            if (id != recibo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recibo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReciboExists(recibo.Id))
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
            return View(recibo);
        }

        // GET: Recibo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Recibo == null)
            {
                return NotFound();
            }

            var recibo = await _context.Recibo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recibo == null)
            {
                return NotFound();
            }

            return View(recibo);
        }

        // POST: Recibo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Recibo == null)
            {
                return Problem("Entity set 'DataContext.Recibo'  is null.");
            }
            var recibo = await _context.Recibo.FindAsync(id);
            if (recibo != null)
            {
                _context.Recibo.Remove(recibo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReciboExists(int id)
        {
          return _context.Recibo.Any(e => e.Id == id);
        }
    }
}
