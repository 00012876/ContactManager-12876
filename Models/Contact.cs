using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContactManager12876.Models
{
    public class Contact
    {
        //00012876
        public int ContactId { get; set; }

        [Required(ErrorMessage = "first name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "last name")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "phone number")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage ="category")]
        public int? CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        public DateTime DateAdded { get; set; }

        public string Slug => FirstName?.Replace(' ','-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
