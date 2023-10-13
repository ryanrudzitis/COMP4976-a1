using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class PaymentMethod
    {
        [Key]
        [Display(Name = "Payment Method")]
        public int PaymentMethodId { get; set; }

        [Required(ErrorMessage = "Name of the payment method is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Created date is required.")]
        public DateTime Created { get; set; }

        [Required(ErrorMessage = "Modified date is required.")]
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}
