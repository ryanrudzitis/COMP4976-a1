using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public class ContactList
    {
        [Key]
        [Display(Name = "Account Name")]
        public int AccountNo { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "First Name should not contain numbers.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Last Name should not contain numbers.")]
        public string? LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string? FullName { get {
                return FirstName + " " + LastName;
            } 
        }


        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        public string? Street { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string? Country { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }
    }
}
