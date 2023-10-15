using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment1.Data;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class DonationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Donations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Donations.Include(d => d.Account).Include(d => d.PaymentMethod).Include(d => d.TransactionType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Donations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Donations == null)
            {
                return NotFound();
            }

            var donations = await _context.Donations
                .Include(d => d.Account)
                .Include(d => d.PaymentMethod)
                .Include(d => d.TransactionType)
                .FirstOrDefaultAsync(m => m.TransId == id);
            if (donations == null)
            {
                return NotFound();
            }

            return View(donations);
        }

        // GET: Donations/Create
        public IActionResult Create()
        {
            ViewData["AccountNo"] = new SelectList(_context.ContactList, "AccountNo", "FullName");
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethod, "PaymentMethodId", "Name");
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionType, "TransactionTypeId", "Name");
            return View();
        }

        // POST: Donations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransId,TransactionTypeId,AccountNo,PaymentMethodId,Date,Amount,Notes")] Donations donations)
        {
            if (ModelState.IsValid)
            {
                donations.Created = DateTime.Now;
                donations.Modified = DateTime.Now;
                donations.CreatedBy = User.Identity!.Name;
                donations.ModifiedBy = User.Identity!.Name;
                _context.Add(donations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountNo"] = new SelectList(_context.ContactList, "AccountNo", "AccountNo", donations.AccountNo);
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethod, "PaymentMethodId", "PaymentMethodId", donations.PaymentMethodId);
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionType, "TransactionTypeId", "TransactionTypeId", donations.TransactionTypeId);

            return View(donations);
        }

        // GET: Donations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Donations == null)
            {
                return NotFound();
            }

            var donations = await _context.Donations.FindAsync(id);
            if (donations == null)
            {
                return NotFound();
            }
            ViewData["AccountNo"] = new SelectList(_context.ContactList, "AccountNo", "FullName", donations.AccountNo);
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethod, "PaymentMethodId", "Name", donations.PaymentMethodId);
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionType, "TransactionTypeId", "Name", donations.TransactionTypeId);

            return View(donations);
        }

        // POST: Donations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransId,TransactionTypeId,AccountNo,PaymentMethodId,Date,Amount,Notes, Created, Modified, CreatedBy, ModifiedBy")] Donations donations)
        {
            if (id != donations.TransId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    donations.Modified = DateTime.Now;
                    donations.ModifiedBy = User.Identity!.Name;
                    _context.Update(donations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonationsExists(donations.TransId))
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
            ViewData["AccountNo"] = new SelectList(_context.ContactList, "AccountNo", "FullName", donations.AccountNo);
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethod, "PaymentMethodId", "PaymentMethodId", donations.PaymentMethodId);
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionType, "TransactionTypeId", "TransactionTypeId", donations.TransactionTypeId);
            return View(donations);
        }

        // GET: Donations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Donations == null)
            {
                return NotFound();
            }

            var donations = await _context.Donations
                .Include(d => d.Account)
                .Include(d => d.PaymentMethod)
                .Include(d => d.TransactionType)
                .FirstOrDefaultAsync(m => m.TransId == id);
            if (donations == null)
            {
                return NotFound();
            }

            return View(donations);
        }

        // POST: Donations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Donations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Donations'  is null.");
            }
            var donations = await _context.Donations.FindAsync(id);
            if (donations != null)
            {
                _context.Donations.Remove(donations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonationsExists(int id)
        {
            return (_context.Donations?.Any(e => e.TransId == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Report()
        {
            var donations = await _context.Donations.ToListAsync();
            var donationsByYear = new Dictionary<int, float>();

            foreach (var donation in donations)
            {
                var year = donation.Date.Year;
                var amount = donation.Amount;

                if (donationsByYear.ContainsKey(year))
                {
                    donationsByYear[year] += amount;
                }
                else
                {
                    donationsByYear.Add(year, amount);
                }
            }

            return View(donationsByYear);
        }   
    }
}
