using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectTaskAssignment
    {
        public int ProjectTaskAssignmentId { get; set; }
        public int ProjectTaskId { get; set; }
        public int EmployeeId { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
    }
}
