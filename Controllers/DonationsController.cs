using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment1.Controllers
{
    [Authorize(Roles = "Admin,Finance")]
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
            var donations = await _context.Donations.Include(d => d.Account).Include(d => d.PaymentMethod).Include(d => d.TransactionType).ToListAsync();
            return _context.Donations != null ?

                        View(donations) :
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
            // now get all the transaction type names using the ids
            var transactionTypeNames = new List<string>();
            foreach (var id in transactionTypes)
            {
                var transactionTypeName = _context.TransactionType.Where(x => x.TransactionTypeId == id).Select(x => x.Name).FirstOrDefault();
                transactionTypeNames.Add(transactionTypeName!);
            }
            // var transactionTypeSelectList = new SelectList(transactionTypes);
            var transactionTypeSelectList = new SelectList(transactionTypeNames);

            var paymentMethods = _context.PaymentMethod.Select(x => x.PaymentMethodId).Distinct().ToList();
            var paymentMethodSelectList = new SelectList(paymentMethods);

            var ContactList = _context.ContactList.Select(x => x.AccountNo).Distinct().ToList();
            Console.WriteLine(ContactList);
            var ContactListSelectList = new SelectList(ContactList);

            ViewData["transactionTypeSelectList"] = transactionTypeSelectList;
            ViewData["contactListSelectList"] = ContactListSelectList;
            ViewData["paymentMethodSelectList"] = paymentMethodSelectList;
            return View();
        }


        // POST: Donations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransId,Date,AccountNo,TransactionTypeId,Amount,PaymentMethodId,Notes")] Donations donations)
        {
            // get username of logged in user
            var userName = User.Identity!.Name;
            if (ModelState.IsValid)
            {

                donations.Created = DateTime.Now;
                donations.Modified = DateTime.Now;
                donations.CreatedBy = userName;
                donations.ModifiedBy = userName;

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

            var userName = User.Identity!.Name;
            donations.Modified = DateTime.Now;
            donations.ModifiedBy = userName;

            // get values for foreign key dropdowns

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
