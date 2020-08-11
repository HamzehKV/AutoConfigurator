using AutoConfiguratorApp.Data;
using AutoConfiguratorApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AutoConfiguratorApp.Controllers
{
    public class AutoKonfigurationsController : Controller
    {
        private readonly AkDbContext _context;

        public AutoKonfigurationsController(AkDbContext context)
        {
            _context = context;
        }

        // GET: AutoKonfigurations
        public async Task<IActionResult> Index()
        {
            return View(await _context.AutoKonfigurationen.ToListAsync());
        }

        // GET: AutoKonfigurations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoKonfiguration = await _context.AutoKonfigurationen
                .FirstOrDefaultAsync(m => m.AutoKonfigurationId == id);
            if (autoKonfiguration == null)
            {
                return NotFound();
            }

            return View(autoKonfiguration);
        }

        // GET: AutoKonfigurations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AutoKonfigurations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoKonfigurationId")] AutoKonfiguration autoKonfiguration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoKonfiguration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autoKonfiguration);
        }

        // GET: AutoKonfigurations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoKonfiguration = await _context.AutoKonfigurationen.FindAsync(id);
            if (autoKonfiguration == null)
            {
                return NotFound();
            }
            return View(autoKonfiguration);
        }

        // POST: AutoKonfigurations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoKonfigurationId")] AutoKonfiguration autoKonfiguration)
        {
            if (id != autoKonfiguration.AutoKonfigurationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoKonfiguration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoKonfigurationExists(autoKonfiguration.AutoKonfigurationId))
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
            return View(autoKonfiguration);
        }

        // GET: AutoKonfigurations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoKonfiguration = await _context.AutoKonfigurationen
                .FirstOrDefaultAsync(m => m.AutoKonfigurationId == id);
            if (autoKonfiguration == null)
            {
                return NotFound();
            }

            return View(autoKonfiguration);
        }

        // POST: AutoKonfigurations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autoKonfiguration = await _context.AutoKonfigurationen.FindAsync(id);
            _context.AutoKonfigurationen.Remove(autoKonfiguration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoKonfigurationExists(int id)
        {
            return _context.AutoKonfigurationen.Any(e => e.AutoKonfigurationId == id);
        }
    }
}
