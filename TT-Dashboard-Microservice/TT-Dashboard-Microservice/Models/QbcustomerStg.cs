using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class QbcustomerStg
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string ParentListId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TermsListId { get; set; }
        public decimal? Balance { get; set; }
        public decimal? TotalBalance { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
