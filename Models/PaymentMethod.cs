using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class PaymentMethod
    {
        [Key]
        [Display(Name = "Payment Method")]
        public int PaymentMethodId { get; set; }
        public string? Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}