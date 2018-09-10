using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataManagementTool.Data
{
    public class Contact : BaseEntity
    {
        public Contact()
        {
        }
        public long? ContactListId { get; set; }
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        //[RegularExpression(ECampaignRegex.Email, ErrorMessage = "Email address is not valid")]
        public string Email { get; set; }

        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }

        [Display(Name = "Phone Number")]
        //[RegularExpression(ECampaignRegex.PhoneNumber, ErrorMessage = "Phone number is not valid")]
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Display(Name = "Company Name")]
        public string Company_Name { get; set; }

        [Display(Name = "First Name")]
        public string First_Name { get; set; }

        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [Display(Name = "Full Name")]
        public string Full_Name { get; set; }

        [Display(Name = "Job Title")]
        public string Job_Title { get; set; }

        [Display(Name = "Prefix")]
        public string Prefix { get; set; }

        [Display(Name = "Suffix")]
        public string Suffix { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        [Display(Name = "Address")]

        public string Address_1 { get; set; }

        [Display(Name = "Zip Code")]
        public string Zip_Code { get; set; }

        [Display(Name = "Cell Number")]
        public string Cell_Number { get; set; }

        [Display(Name = "Web Address")]
        public string URL { get; set; }

        [Display(Name = "Mailing Address State")]
        public string Mailing_Address_State { get; set; }

        [Display(Name = "Mailing Address City")]
        public string Mailing_Address_City { get; set; }

        [Display(Name = "Mailing Address Standardized")]
        public string Mailing_Address_Standardized { get; set; }

        [Display(Name = "Mailing Address Zip in 5Digit")]

        public string Mailing_Address_Zip_5Digit { get; set; }

        [Display(Name = "Mailing Address Zip Plus4")]

        public string Mailing_Address_Zip_Plus4 { get; set; }

        [Display(Name = "Location Employees Total")]
        public string Location_Employees_Total { get; set; }

        [Display(Name = "Location Sale Total")]
        public string Location_Sales_Total { get; set; }

        [Display(Name = "Square Footage")]
        public string Square_Footage { get; set; }

        [Display(Name = "Primary SIC")]

        public string Primary_SIC { get; set; }

        [Display(Name = "Primary SIC Description")]

        public string Primary_SIC_Description { get; set; }

        [Display(Name = "Selected SIC")]

        public string Selected_SIC { get; set; }

        [Display(Name = "Selected SIC Description")]

        public string Selected_SIC_Description { get; set; }

        [Display(Name = "Established Year")]

        public string Year_Established { get; set; }

        [Display(Name = "County Description")]

        public string County_Description { get; set; }

        [Display(Name = "CBSA Description")]

        public string CBSA_Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDoNotSend { get; set; }


    }
}
