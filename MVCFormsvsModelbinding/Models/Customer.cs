using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormsvsModelbinding.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
    }
}
