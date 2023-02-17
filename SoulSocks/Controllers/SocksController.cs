using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoulSocks.Data;
using SoulSocks.Models;

namespace SoulSocks.Controllers
{
    public class SocksController : Controller
    {
        private readonly SoulSocksContext _context;

        public SocksController(SoulSocksContext context)
        {
            _context = context;
        }

        // GET: Socks
        public async Task<IActionResult> Index(string sockMaterial, string searchString)
        {
            IQueryable<string> materialQuery = from s in _context.Sock
                                            orderby s.Material
                                            select s.Material; 
            var socks = from s in _context.Sock
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                socks = socks.Where(s => s.Brand.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(sockMaterial))
            {
                socks = socks.Where(x => x.Material == sockMaterial);
            }

            var sockMaterialVM = new SockMaterialViewModel
            {
                Material = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Socks = await socks.ToListAsync()
            };

            return View(sockMaterialVM);
        }

        // GET: Socks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sock = await _context.Sock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sock == null)
            {
                return NotFound();
            }

            return View(sock);
        }

        // GET: Socks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Socks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Material,Length,Colour,Price,Rating")] Sock sock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sock);
        }

        // GET: Socks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sock = await _context.Sock.FindAsync(id);
            if (sock == null)
            {
                return NotFound();
            }
            return View(sock);
        }

        // POST: Socks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Material,Length,Colour,Price,Rating")] Sock sock)
        {
            if (id != sock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SockExists(sock.Id))
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
            return View(sock);
        }

        // GET: Socks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sock = await _context.Sock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sock == null)
            {
                return NotFound();
            }

            return View(sock);
        }

        // POST: Socks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sock = await _context.Sock.FindAsync(id);
            _context.Sock.Remove(sock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SockExists(int id)
        {
            return _context.Sock.Any(e => e.Id == id);
        }
    }
}
