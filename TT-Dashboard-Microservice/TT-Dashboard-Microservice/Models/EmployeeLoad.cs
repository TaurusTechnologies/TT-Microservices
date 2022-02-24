using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class EmployeeLoad
    {
        public string SAmaccountName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string Department { get; set; }
        public string TelephoneNumber { get; set; }
        public string DistinguishedName { get; set; }
        public string ManagerDn { get; set; }
        public int? ManagerId { get; set; }
        public string MiddleName { get; set; }
    }
}
