using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Qbaccount
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string ParentAccountListId { get; set; }
        public string AccountType { get; set; }
        public string SpecialAccountType { get; set; }
        public string AccountNumber { get; set; }
        public string BankNumber { get; set; }
        public string Desc { get; set; }
        public decimal? Balance { get; set; }
        public decimal? TotalBalance { get; set; }
    }
}
