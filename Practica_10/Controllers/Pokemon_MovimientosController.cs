using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practica_10;
using Practica_10.Context;

namespace Practica_10.Controllers
{
    public class Pokemon_MovimientosController : Controller
    {
        private readonly MyDbContext _context;

        public Pokemon_MovimientosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Pokemon_Movimientos
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Pokemon_Movimientos.Include(p => p.Movimiento).Include(p => p.Pokemon);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Pokemon_Movimientos/Details/5
        public async Task<IActionResult> Details(int? NumMovimiento, int? NumPokemon)
        {
            if (NumMovimiento == null || NumPokemon == null)
            {
                return NotFound();
            }

            var pokemon_Movimiento = await _context.Pokemon_Movimientos
                .Include(p => p.Movimiento)
                .Include(p => p.Pokemon)
                .FirstOrDefaultAsync(m => m.NumPokemon == NumPokemon && m.NumMovimiento == NumMovimiento);
            if (pokemon_Movimiento == null)
            {
                return NotFound();
            }

            return View(pokemon_Movimiento);
        }

        // GET: Pokemon_Movimientos/Create
        public IActionResult Create()
        {
            ViewData["NumMovimiento"] = new SelectList(_context.Movimientos, "NumeroMovimiento", "Nombre");
            ViewData["NumPokemon"] = new SelectList(_context.Pokemones, "NumeroPokemon", "NumeroPokemon");
            return View();
        }

        // POST: Pokemon_Movimientos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumMovimiento,NumPokemon")] Pokemon_Movimiento pokemon_Movimiento)
        {

            _context.Add(pokemon_Movimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // GET: Pokemon_Movimientos/Edit/5
        public async Task<IActionResult> Edit(int? NumMovimiento, int? NumPokemon)
        {
            if (NumMovimiento == null || NumPokemon == null)
            {
                return NotFound();
            }

            var pokemon_Movimiento = await _context.Pokemon_Movimientos.FindAsync(NumMovimiento, NumPokemon);
            if (pokemon_Movimiento == null)
            {
                return NotFound();
            }
            ViewData["NumMovimiento"] = new SelectList(_context.Movimientos, "NumeroMovimiento", "Nombre", pokemon_Movimiento.NumMovimiento);
            ViewData["NumPokemon"] = new SelectList(_context.Pokemones, "NumeroPokemon", "NumeroPokemon", pokemon_Movimiento.NumPokemon);
            return View(pokemon_Movimiento);
        }

        // POST: Pokemon_Movimientos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? NumMovimiento, int? NumPokemon, [Bind("NumMovimiento,NumPokemon")] Pokemon_Movimiento pokemon_Movimiento)
        {
            if (NumMovimiento != pokemon_Movimiento.NumMovimiento || NumPokemon != pokemon_Movimiento.NumPokemon)
            {
                return NotFound();
            }


            _context.Update(pokemon_Movimiento);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));

        }

        // GET: Pokemon_Movimientos/Delete/5
        public async Task<IActionResult> Delete(int? NumMovimiento, int? NumPokemon)
        {
            if (NumMovimiento == null || NumPokemon == null)
            {
                return NotFound();
            }

            var pokemon_Movimiento = await _context.Pokemon_Movimientos
                .Include(p => p.Movimiento)
                .Include(p => p.Pokemon)
                .FirstOrDefaultAsync(m => m.NumMovimiento == NumMovimiento && m.NumPokemon == NumPokemon);
            if (pokemon_Movimiento == null)
            {
                return NotFound();
            }

            return View(pokemon_Movimiento);
        }

        // POST: Pokemon_Movimientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? NumMovimiento, int? NumPokemon)
        {
            var pokemon_Movimiento = await _context.Pokemon_Movimientos.FindAsync(NumMovimiento, NumPokemon);
            if (pokemon_Movimiento != null)
            {
                _context.Pokemon_Movimientos.Remove(pokemon_Movimiento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Pokemon_MovimientoExists(int? NumMovimiento, int? NumPokemon)
        {
            return _context.Pokemon_Movimientos.Any(e => e.NumMovimiento == NumMovimiento && e.NumPokemon == NumPokemon);
        }
    }
}
