using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class TransactionType
    {
        [Key]
        [Display(Name = "Transaction Type Id")]
        public int TransactionTypeId { get; set; }

        [Required(ErrorMessage = "Name of the transaction type is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string? Name { get; set; }

        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}
