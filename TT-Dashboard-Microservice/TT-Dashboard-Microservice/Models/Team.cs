using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Team
    {
        public Team()
        {
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
            LeadQuoteRevisions = new HashSet<LeadQuoteRevision>();
            Leads = new HashSet<Lead>();
            ProjectTasks = new HashSet<ProjectTask>();
            Projects = new HashSet<Project>();
            TeamMembers = new HashSet<TeamMember>();
            TroubleTickets = new HashSet<TroubleTicket>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public bool? IsSystem { get; set; }
        public bool? CanViewProcurement { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<LeadQuoteRevision> LeadQuoteRevisions { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<TroubleTicket> TroubleTickets { get; set; }
    }
}
