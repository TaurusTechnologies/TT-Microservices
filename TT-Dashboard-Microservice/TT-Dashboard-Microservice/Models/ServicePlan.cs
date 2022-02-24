using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ServicePlan
    {
        public ServicePlan()
        {
            Projects = new HashSet<Project>();
        }

        public int ServicePlanId { get; set; }
        public string Name { get; set; }
        public int DurationDays { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
