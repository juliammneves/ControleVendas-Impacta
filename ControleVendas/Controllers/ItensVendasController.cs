using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleVendas.Data;
using ControleVendas.Models;

namespace ControleVendas.Controllers
{
    public class ItensVendasController : Controller
    {
        private readonly ControleVendasDbContext _context;

        public ItensVendasController(ControleVendasDbContext context)
        {
            _context = context;
        }

        // GET: ItensVendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItensVenda.ToListAsync());
        }

        // GET: ItensVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensVenda = await _context.ItensVenda
                .FirstOrDefaultAsync(m => m.ItensVendaID == id);
            if (itensVenda == null)
            {
                return NotFound();
            }

            return View(itensVenda);
        }

        // GET: ItensVendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItensVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItensVendaID,VendaID,ProdutoID,Quantidade,PrecoVenda,Desconto")] ItensVenda itensVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itensVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itensVenda);
        }

        // GET: ItensVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensVenda = await _context.ItensVenda.FindAsync(id);
            if (itensVenda == null)
            {
                return NotFound();
            }
            return View(itensVenda);
        }

        // POST: ItensVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItensVendaID,VendaID,ProdutoID,Quantidade,PrecoVenda,Desconto")] ItensVenda itensVenda)
        {
            if (id != itensVenda.ItensVendaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itensVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItensVendaExists(itensVenda.ItensVendaID))
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
            return View(itensVenda);
        }

        // GET: ItensVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensVenda = await _context.ItensVenda
                .FirstOrDefaultAsync(m => m.ItensVendaID == id);
            if (itensVenda == null)
            {
                return NotFound();
            }

            return View(itensVenda);
        }

        // POST: ItensVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itensVenda = await _context.ItensVenda.FindAsync(id);
            if (itensVenda != null)
            {
                _context.ItensVenda.Remove(itensVenda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItensVendaExists(int id)
        {
            return _context.ItensVenda.Any(e => e.ItensVendaID == id);
        }
    }
}
