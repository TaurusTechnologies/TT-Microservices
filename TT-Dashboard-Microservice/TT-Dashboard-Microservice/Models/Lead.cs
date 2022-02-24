using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Lead
    {
        public Lead()
        {
            Expenses = new HashSet<Expense>();
            ItemComments = new HashSet<ItemComment>();
            ItemFiles = new HashSet<ItemFile>();
            ItemFollowUps = new HashSet<ItemFollowUp>();
            ItemFollowers = new HashSet<ItemFollower>();
            LeadAssignments = new HashSet<LeadAssignment>();
            LeadQuotes = new HashSet<LeadQuote>();
            LeadStartStopDates = new HashSet<LeadStartStopDate>();
            TimeLogs = new HashSet<TimeLog>();
            TroubleTickets = new HashSet<TroubleTicket>();
        }

        public int LeadId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastModified { get; set; }
        public int? CustomerId { get; set; }
        public int? TeamId { get; set; }
        public string ContactRole { get; set; }
        public decimal? AnticipatedBudget { get; set; }
        public DateTime? AnticipatedStartDate { get; set; }
        public string Industry { get; set; }
        public string Source { get; set; }
        public decimal? ClosureRate { get; set; }
        public string CellPhone { get; set; }
        public int? LeadTypeId { get; set; }
        public string ProjectCode { get; set; }
        public string WorkflowStatus { get; set; }
        public int? DesignApproverId { get; set; }
        public int? PricingApproverId { get; set; }
        public DateTime? DesignApprovalDate { get; set; }
        public DateTime? PricingApprovalDate { get; set; }
        public int? IndustryTypeId { get; set; }
        public DateTime? AnticipatedEndDate { get; set; }
        public string QbcustomerListId { get; set; }
        public int? CreatedById { get; set; }
        public byte[] Logo { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Employee CreatedBy { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee DesignApprover { get; set; }
        public virtual IndustryType IndustryType { get; set; }
        public virtual LeadType LeadType { get; set; }
        public virtual Employee PricingApprover { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<ItemComment> ItemComments { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<ItemFollower> ItemFollowers { get; set; }
        public virtual ICollection<LeadAssignment> LeadAssignments { get; set; }
        public virtual ICollection<LeadQuote> LeadQuotes { get; set; }
        public virtual ICollection<LeadStartStopDate> LeadStartStopDates { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }
        public virtual ICollection<TroubleTicket> TroubleTickets { get; set; }
    }
}
