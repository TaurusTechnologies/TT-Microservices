using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectTask
    {
        public ProjectTask()
        {
            ProjectTaskAssignments = new HashSet<ProjectTaskAssignment>();
        }

        public int ProjectTaskId { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public int? TeamId { get; set; }
        public int? ActivityId { get; set; }
        public string Notes { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Project Project { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<ProjectTaskAssignment> ProjectTaskAssignments { get; set; }
    }
}
