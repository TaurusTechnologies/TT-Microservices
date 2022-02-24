using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class LeadStartStopDate
    {
        public int LeadStartStopDateId { get; set; }
        public int LeadId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }

        public virtual Lead Lead { get; set; }
    }
}
