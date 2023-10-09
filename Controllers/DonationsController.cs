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
              return _context.Donations != null ? 
                          View(await _context.Donations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Donations'  is null.");
        }

        // GET: Donations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Donations == null)
            {
                return NotFound();
            }

            var donations = await _context.Donations
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
            var transactionTypes = _context.TransactionType.Select(x => x.TransactionTypeId).Distinct().ToList();
            var transactionTypeSelectList = new SelectList(transactionTypes);

            var paymentMethods = _context.PaymentMethod.Select(x => x.PaymentMethodId).Distinct().ToList();
            var paymentMethodSelectList = new SelectList(paymentMethods);

            var ContactList = _context.ContactList.Select(x => x.AccountNo).Distinct().ToList();
            var ContactListSelectList = new SelectList(ContactList);

            ViewData["contactListSelectList"] = ContactListSelectList;
            ViewData["transactionTypeSelectList"] = transactionTypeSelectList;
            ViewData["paymentMethodSelectList"] = paymentMethodSelectList;
            return View();
        }


        // POST: Donations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransId,Date,AccountNo,TransactionTypeId,Amount,PaymentMethodId,Notes,Created,Modified,CreatedBy,ModifiedBy")] Donations donations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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

            var transactionTypes = _context.TransactionType.Select(x => x.TransactionTypeId).Distinct().ToList();
            var transactionTypeSelectList = new SelectList(transactionTypes);

            var paymentMethods = _context.PaymentMethod.Select(x => x.PaymentMethodId).Distinct().ToList();
            var paymentMethodSelectList = new SelectList(paymentMethods);

            var ContactList = _context.ContactList.Select(x => x.AccountNo).Distinct().ToList();
            var ContactListSelectList = new SelectList(ContactList);

            ViewData["contactListSelectList"] = ContactListSelectList;
            ViewData["transactionTypeSelectList"] = transactionTypeSelectList;
            ViewData["paymentMethodSelectList"] = paymentMethodSelectList;
            
            return View(donations);
        }

        // POST: Donations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransId,Date,AccountNo,TransactionTypeId,Amount,PaymentMethodId,Notes,Created,Modified,CreatedBy,ModifiedBy")] Donations donations)
        {
            if (id != donations.TransId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
    }
}
