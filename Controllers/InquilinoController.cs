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
    public class InquilinoController : Controller
    {
        private readonly DataContext _context;

        public InquilinoController(DataContext context)
        {
            _context = context;
        }

        // GET: Inquilino
        public async Task<IActionResult> Index()
        {
              return View(await _context.Inquilino.ToListAsync());
        }

        // GET: Inquilino/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Inquilino == null)
            {
                return NotFound();
            }

            var inquilino = await _context.Inquilino
                .FirstOrDefaultAsync(m => m.InquilinoId == id);
            if (inquilino == null)
            {
                return NotFound();
            }

            return View(inquilino);
        }

        // GET: Inquilino/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inquilino/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InquilinoId,Nombre,Apellido,Identificacion,Sexo,FechaDeAlta,FechaDeBaja")] Inquilino inquilino)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquilino);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inquilino);
        }

        // GET: Inquilino/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Inquilino == null)
            {
                return NotFound();
            }

            var inquilino = await _context.Inquilino.FindAsync(id);
            if (inquilino == null)
            {
                return NotFound();
            }
            return View(inquilino);
        }

        // POST: Inquilino/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InquilinoId,Nombre,Apellido,Identificacion,Sexo,FechaDeAlta,FechaDeBaja")] Inquilino inquilino)
        {
            if (id != inquilino.InquilinoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inquilino);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InquilinoExists(inquilino.InquilinoId))
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
            return View(inquilino);
        }

        // GET: Inquilino/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Inquilino == null)
            {
                return NotFound();
            }

            var inquilino = await _context.Inquilino
                .FirstOrDefaultAsync(m => m.InquilinoId == id);
            if (inquilino == null)
            {
                return NotFound();
            }

            return View(inquilino);
        }

        // POST: Inquilino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Inquilino == null)
            {
                return Problem("Entity set 'DataContext.Inquilino'  is null.");
            }
            var inquilino = await _context.Inquilino.FindAsync(id);
            if (inquilino != null)
            {
                _context.Inquilino.Remove(inquilino);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InquilinoExists(int id)
        {
          return _context.Inquilino.Any(e => e.InquilinoId == id);
        }
    }
}
