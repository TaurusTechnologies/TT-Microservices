using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class LeadAssignment
    {
        public int LeadAssignmentId { get; set; }
        public int LeadId { get; set; }
        public int EmployeeId { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Lead Lead { get; set; }
    }
}
