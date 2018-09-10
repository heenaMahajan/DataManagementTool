using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagementTool.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        [Required]
        [MaxLength(80)]
        [RegularExpression(@"^[a-zA-Z0-9,!#\$%&'\*\+/=\?\^_`\{\|}~-]+(\.[a-zA-Z0-9,!#\$%&'\*\+/=\?\^_`\{\|}~-]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.([a-zA-Z]{2,})$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }
        public string AddedDateValue { get; set; }

        [Required]
        [Display(Name = "Member type")]
        public string Role { get; set; }
        public string EncryptedPassword { get; set; }
        public bool IsActive { get; set; }
    }

    
}
