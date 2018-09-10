using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementTool.Models
{
    public class ClientViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Email")]
        [MaxLength(80)]
        [RegularExpression(@"^[a-zA-Z0-9,!#\$%&'\*\+/=\?\^_`\{\|}~-]+(\.[a-zA-Z0-9,!#\$%&'\*\+/=\?\^_`\{\|}~-]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.([a-zA-Z]{2,})$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address Street")]
        [MaxLength(500)]
        public string AddressStreet { get; set; }

        [Display(Name = "Address Street2")]
        [MaxLength(500)]
        public string AddressStreet2 { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }

        [Display(Name = "Additional Details")]
        public string AdditionalDetails { get; set; }

        public string Company { get; set; }
        public string Role { get; set; }




    }
}
