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
    public class PokemonesController : Controller
    {
        private readonly MyDbContext _context;

        public PokemonesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Pokemones
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Pokemones.Include(p => p.Jugador);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Pokemones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemones
                .Include(p => p.Jugador)
                .FirstOrDefaultAsync(m => m.NumeroPokemon == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // GET: Pokemones/Create
        public IActionResult Create()
        {
            ViewData["JugadorId"] = new SelectList(_context.Jugadores, "NumeroJugador", "Nombre");
            return View();
        }

        // POST: Pokemones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumeroPokemon,Nombre,Nivel,JugadorId")] Pokemon pokemon)
        {
           
                _context.Add(pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Pokemones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemones.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            ViewData["JugadorId"] = new SelectList(_context.Jugadores, "NumeroJugador", "Nombre", pokemon.JugadorId);
            return View(pokemon);
        }

        // POST: Pokemones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumeroPokemon,Nombre,Nivel,JugadorId")] Pokemon pokemon)
        {
            if (id != pokemon.NumeroPokemon)
            {
                return NotFound();
            }

            
                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
               
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Pokemones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemones
                .Include(p => p.Jugador)
                .FirstOrDefaultAsync(m => m.NumeroPokemon == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // POST: Pokemones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokemon = await _context.Pokemones.FindAsync(id);
            if (pokemon != null)
            {
                _context.Pokemones.Remove(pokemon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonExists(int id)
        {
            return _context.Pokemones.Any(e => e.NumeroPokemon == id);
        }
    }
}
