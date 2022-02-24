using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class LeadQuoteRevisionAssignment
    {
        public int Id { get; set; }
        public int LeadQuoteRevisionId { get; set; }
        public int EmployeeId { get; set; }
        public bool? IsPrimary { get; set; }
        public bool Transient { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual LeadQuoteRevision LeadQuoteRevision { get; set; }
    }
}
