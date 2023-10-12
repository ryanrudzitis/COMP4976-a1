using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class TransactionType
    {
        [Key]
        [Display(Name = "Transaction Type Id")]
        public int TransactionTypeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}