using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectStartStopDate
    {
        public int ProjectStartStopDateId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }

        public virtual Project Project { get; set; }
    }
}
