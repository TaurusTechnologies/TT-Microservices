using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectAssignment
    {
        public int ProjectAssignmentId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public bool? IsPrimary { get; set; }
        public bool? IsProgrammer { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
