using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Donations
    {
        [Key]
        [Display(Name = "Transaction ID")]
        public int TransId { get; set; }
        public int TransactionTypeId { get; set; }
        
        public int AccountNo { get; set; }

        public int PaymentMethodId { get; set; }

        public DateTime Date { get; set; }
        
        [ForeignKey("AccountNo")]
        [Display(Name = "Account Number")]
        public ContactList? Account { get; set; }

        [ForeignKey("TransactionTypeId")]
        [Display(Name = "Transaction Type")]
        public TransactionType? TransactionType { get; set; }

        public float Amount { get; set; }

        [ForeignKey("PaymentMethodId")]
        [Display(Name = "Payment Method")]
        public PaymentMethod? PaymentMethod { get; set; }
        // public int PaymentMethodId { get; set; }

        public string? Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }
        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}