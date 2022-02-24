using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectAccountingStatus
    {
        public ProjectAccountingStatus()
        {
            Projects = new HashSet<Project>();
        }

        public int AccountingStatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
