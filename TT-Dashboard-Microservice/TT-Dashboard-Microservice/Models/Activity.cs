using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ProjectTasks = new HashSet<ProjectTask>();
            TimeLogs = new HashSet<TimeLog>();
        }

        public int ActivityId { get; set; }
        public string Name { get; set; }
        public decimal? BillableRate { get; set; }
        public int? BillingType { get; set; }

        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }
    }
}
