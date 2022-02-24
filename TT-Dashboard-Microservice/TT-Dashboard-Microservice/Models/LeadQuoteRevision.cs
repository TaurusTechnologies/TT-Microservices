using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class LeadQuoteRevision
    {
        public LeadQuoteRevision()
        {
            ItemComments = new HashSet<ItemComment>();
            ItemFiles = new HashSet<ItemFile>();
            ItemFollowUps = new HashSet<ItemFollowUp>();
            ItemFollowers = new HashSet<ItemFollower>();
            LeadQuoteRevisionAssignments = new HashSet<LeadQuoteRevisionAssignment>();
            Projects = new HashSet<Project>();
            RevisionRooms = new HashSet<RevisionRoom>();
        }

        public int LeadQuoteRevisionId { get; set; }
        public int LeadQuoteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public bool? RequiresDesignApproval { get; set; }
        public DateTime? DesignApprovedOn { get; set; }
        public string DesignApprovedBy { get; set; }
        public bool? RequiresPricingApproval { get; set; }
        public DateTime? PricingApprovedOn { get; set; }
        public string PricingApprovedBy { get; set; }
        public bool? RequiresManagerApproval { get; set; }
        public DateTime? ManagerApprovedOn { get; set; }
        public string ManagerApprovedBy { get; set; }
        public int? TeamId { get; set; }
        public DateTime? SubmittedForApprovalDate { get; set; }
        public string SubmittedForApprovalBy { get; set; }

        public virtual LeadQuote LeadQuote { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<ItemComment> ItemComments { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<ItemFollower> ItemFollowers { get; set; }
        public virtual ICollection<LeadQuoteRevisionAssignment> LeadQuoteRevisionAssignments { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<RevisionRoom> RevisionRooms { get; set; }
    }
}
