using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoConfiguratorApp.Data;
using AutoConfiguratorApp.Models;

namespace AutoConfiguratorApp.Controllers
{
    public class AutoKonfigurationenController : Controller
    {
        private readonly AkDbContext _context;

        public AutoKonfigurationenController(AkDbContext context)
        {
            _context = context;
        }

        // GET: AutoKonfigurationen
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var akDbContext = _context.AutoKonfigurationen.Include(a => a.AutoModell_Felge).Include(a => a.AutoModell_Lackierung).Include(a => a.AutoModell_Motor).Include(a => a.FahrSicherheitsSystem).Include(a => a.KlimaAnlage).Include(a => a.NavigationsSystem).Include(a => a.ParkAssistentSystem).Include(a => a.SoundSystem);
            return View(await akDbContext.ToListAsync());
        }

        // GET: AutoKonfigurationen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoKonfiguration = await _context.AutoKonfigurationen
                .Include(a => a.AutoModell_Felge)
                .Include(a => a.AutoModell_Lackierung)
                .Include(a => a.AutoModell_Motor)
                .Include(a => a.FahrSicherheitsSystem)
                .Include(a => a.KlimaAnlage)
                .Include(a => a.NavigationsSystem)
                .Include(a => a.ParkAssistentSystem)
                .Include(a => a.SoundSystem)
                .FirstOrDefaultAsync(m => m.AutoKonfigurationId == id);
            if (autoKonfiguration == null)
            {
                return NotFound();
            }

            return View(autoKonfiguration);
        }

        // GET: AutoKonfigurationen/Create
        public IActionResult Create()
        {
            ViewData["AM_F_RefId"] = new SelectList(_context.AutoModelle_Felgen, "AutoModell_FelgeId", "AutoModell_FelgeId");
            ViewData["AM_L_RefId"] = new SelectList(_context.AutoModelle_Lackierungen, "AutoModell_LackierungId", "AutoModell_LackierungId");
            ViewData["AM_M_RefId"] = new SelectList(_context.AutoModelle_Motoren, "AutoModell_MotorId", "AutoModell_MotorId");
            ViewData["FSS_RefId"] = new SelectList(_context.FahrSicherheitsSysteme, "FahrSicherheitsSystemId", "Name");
            ViewData["KA_RefId"] = new SelectList(_context.KlimaAnlagen, "KlimaAnlageId", "Name");
            ViewData["NS_RefId"] = new SelectList(_context.NavigationsSysteme, "NavigationsSystemId", "Model");
            ViewData["PAS_RefId"] = new SelectList(_context.ParkAssistentSysteme, "ParkAssistentSystemId", "Model");
            ViewData["SS_RefId"] = new SelectList(_context.SoundSysteme, "SoundSystemId", "Model");
            return View();
        }

        // POST: AutoKonfigurationen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoKonfigurationId,AM_F_RefId,AM_L_RefId,AM_M_RefId,FSS_RefId,KA_RefId,NS_RefId,PAS_RefId,SS_RefId,CreatedDate,ModifiedDate")] AutoKonfiguration autoKonfiguration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoKonfiguration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AM_F_RefId"] = new SelectList(_context.AutoModelle_Felgen, "AutoModell_FelgeId", "AutoModell_FelgeId", autoKonfiguration.AM_F_RefId);
            ViewData["AM_L_RefId"] = new SelectList(_context.AutoModelle_Lackierungen, "AutoModell_LackierungId", "AutoModell_LackierungId", autoKonfiguration.AM_L_RefId);
            ViewData["AM_M_RefId"] = new SelectList(_context.AutoModelle_Motoren, "AutoModell_MotorId", "AutoModell_MotorId", autoKonfiguration.AM_M_RefId);
            ViewData["FSS_RefId"] = new SelectList(_context.FahrSicherheitsSysteme, "FahrSicherheitsSystemId", "Name", autoKonfiguration.FSS_RefId);
            ViewData["KA_RefId"] = new SelectList(_context.KlimaAnlagen, "KlimaAnlageId", "Name", autoKonfiguration.KA_RefId);
            ViewData["NS_RefId"] = new SelectList(_context.NavigationsSysteme, "NavigationsSystemId", "Model", autoKonfiguration.NS_RefId);
            ViewData["PAS_RefId"] = new SelectList(_context.ParkAssistentSysteme, "ParkAssistentSystemId", "Model", autoKonfiguration.PAS_RefId);
            ViewData["SS_RefId"] = new SelectList(_context.SoundSysteme, "SoundSystemId", "Model", autoKonfiguration.SS_RefId);
            return View(autoKonfiguration);
        }

        // GET: AutoKonfigurationen/Edit/5
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
            ViewData["AM_F_RefId"] = new SelectList(_context.AutoModelle_Felgen, "AutoModell_FelgeId", "AutoModell_FelgeId", autoKonfiguration.AM_F_RefId);
            ViewData["AM_L_RefId"] = new SelectList(_context.AutoModelle_Lackierungen, "AutoModell_LackierungId", "AutoModell_LackierungId", autoKonfiguration.AM_L_RefId);
            ViewData["AM_M_RefId"] = new SelectList(_context.AutoModelle_Motoren, "AutoModell_MotorId", "AutoModell_MotorId", autoKonfiguration.AM_M_RefId);
            ViewData["FSS_RefId"] = new SelectList(_context.FahrSicherheitsSysteme, "FahrSicherheitsSystemId", "Name", autoKonfiguration.FSS_RefId);
            ViewData["KA_RefId"] = new SelectList(_context.KlimaAnlagen, "KlimaAnlageId", "Name", autoKonfiguration.KA_RefId);
            ViewData["NS_RefId"] = new SelectList(_context.NavigationsSysteme, "NavigationsSystemId", "Model", autoKonfiguration.NS_RefId);
            ViewData["PAS_RefId"] = new SelectList(_context.ParkAssistentSysteme, "ParkAssistentSystemId", "Model", autoKonfiguration.PAS_RefId);
            ViewData["SS_RefId"] = new SelectList(_context.SoundSysteme, "SoundSystemId", "Model", autoKonfiguration.SS_RefId);
            return View(autoKonfiguration);
        }

        // POST: AutoKonfigurationen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoKonfigurationId,AM_F_RefId,AM_L_RefId,AM_M_RefId,FSS_RefId,KA_RefId,NS_RefId,PAS_RefId,SS_RefId,CreatedDate,ModifiedDate")] AutoKonfiguration autoKonfiguration)
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
            ViewData["AM_F_RefId"] = new SelectList(_context.AutoModelle_Felgen, "AutoModell_FelgeId", "AutoModell_FelgeId", autoKonfiguration.AM_F_RefId);
            ViewData["AM_L_RefId"] = new SelectList(_context.AutoModelle_Lackierungen, "AutoModell_LackierungId", "AutoModell_LackierungId", autoKonfiguration.AM_L_RefId);
            ViewData["AM_M_RefId"] = new SelectList(_context.AutoModelle_Motoren, "AutoModell_MotorId", "AutoModell_MotorId", autoKonfiguration.AM_M_RefId);
            ViewData["FSS_RefId"] = new SelectList(_context.FahrSicherheitsSysteme, "FahrSicherheitsSystemId", "Name", autoKonfiguration.FSS_RefId);
            ViewData["KA_RefId"] = new SelectList(_context.KlimaAnlagen, "KlimaAnlageId", "Name", autoKonfiguration.KA_RefId);
            ViewData["NS_RefId"] = new SelectList(_context.NavigationsSysteme, "NavigationsSystemId", "Model", autoKonfiguration.NS_RefId);
            ViewData["PAS_RefId"] = new SelectList(_context.ParkAssistentSysteme, "ParkAssistentSystemId", "Model", autoKonfiguration.PAS_RefId);
            ViewData["SS_RefId"] = new SelectList(_context.SoundSysteme, "SoundSystemId", "Model", autoKonfiguration.SS_RefId);
            return View(autoKonfiguration);
        }

        // GET: AutoKonfigurationen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoKonfiguration = await _context.AutoKonfigurationen
                .Include(a => a.AutoModell_Felge)
                .Include(a => a.AutoModell_Lackierung)
                .Include(a => a.AutoModell_Motor)
                .Include(a => a.FahrSicherheitsSystem)
                .Include(a => a.KlimaAnlage)
                .Include(a => a.NavigationsSystem)
                .Include(a => a.ParkAssistentSystem)
                .Include(a => a.SoundSystem)
                .FirstOrDefaultAsync(m => m.AutoKonfigurationId == id);
            if (autoKonfiguration == null)
            {
                return NotFound();
            }

            return View(autoKonfiguration);
        }

        // POST: AutoKonfigurationen/Delete/5
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
