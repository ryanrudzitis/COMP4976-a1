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

        [Required(ErrorMessage = "Transaction Type ID is required.")]
        public int TransactionTypeId { get; set; }

        [Display(Name = "Account Name")]
        [Required(ErrorMessage = "Account Name is required.")]
        public int AccountNo { get; set; }

        [Required(ErrorMessage = "Payment Method ID is required.")]
        public int PaymentMethodId { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [ForeignKey("AccountNo")]
        [Display(Name = "Account Name")]
        public ContactList? Account { get; set; }

        [ForeignKey("TransactionTypeId")]
        [Display(Name = "Transaction Type")]
        public TransactionType? TransactionType { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public float Amount { get; set; }

        [ForeignKey("PaymentMethodId")]
        [Display(Name = "Payment Method")]
        public PaymentMethod? PaymentMethod { get; set; }

        [MaxLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
        public string? Notes { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}
