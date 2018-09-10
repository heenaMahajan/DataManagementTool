using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace DataManagementTool.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsTempPassword { get; set; }
        public bool IsDeleted { get; set; }
        public string Company { get; set; }
        public string AddressStreet { get; set; }
        public string AddressStreet2 { get; set; }
        public string PostalCode { get; set; }
        public string PostalAddress { get; set; }
        public string AdditionalDetails { get; set; } 
    }
}
