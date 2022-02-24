using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class QbvendorStg
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string CompanyName { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string Addr5 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string AltPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public string Contact { get; set; }
        public string AltContact { get; set; }
        public string AccountNumber { get; set; }
        public string VendorTaxIdent { get; set; }
        public bool? IsVendorEligibleFor1099 { get; set; }
        public string TermsRef { get; set; }
        public string VendorTypeRef { get; set; }
        public string AltAddress { get; set; }
        public string AltCityStateZip { get; set; }
        public string W9received { get; set; }
        public string Website { get; set; }
        public string Classification { get; set; }
        public DateTime? Note1Date { get; set; }
        public string Note1 { get; set; }
        public DateTime? Note2Date { get; set; }
        public string Note2 { get; set; }
        public DateTime? Note3Date { get; set; }
        public string Note3 { get; set; }
        public DateTime? Note4Date { get; set; }
        public string Note4 { get; set; }
        public DateTime? Note5Date { get; set; }
        public string Note5 { get; set; }
    }
}
