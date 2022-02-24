using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Project
    {
        public Project()
        {
            Expenses = new HashSet<Expense>();
            ItemComments = new HashSet<ItemComment>();
            ItemFiles = new HashSet<ItemFile>();
            ItemFollowUps = new HashSet<ItemFollowUp>();
            ItemFollowers = new HashSet<ItemFollower>();
            ProjectAssignments = new HashSet<ProjectAssignment>();
            ProjectMclproducts = new HashSet<ProjectMclproduct>();
            ProjectProducts = new HashSet<ProjectProduct>();
            ProjectRooms = new HashSet<ProjectRoom>();
            ProjectStartStopDates = new HashSet<ProjectStartStopDate>();
            ProjectTasks = new HashSet<ProjectTask>();
            RoomServicePlans = new HashSet<RoomServicePlan>();
            ThirdPartySupportContracts = new HashSet<ThirdPartySupportContract>();
            TimeLogs = new HashSet<TimeLog>();
            TroubleTickets = new HashSet<TroubleTicket>();
        }

        public int ProjectId { get; set; }
        public int Status { get; set; }
        public string ProjectCode { get; set; }
        public int CustomerId { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public decimal? Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateWorkCompleted { get; set; }
        public int? ServicePlanId { get; set; }
        public DateTime? DateServicePlanStart { get; set; }
        public DateTime? DateServicePlanEnd { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public int? TeamId { get; set; }
        public string Name { get; set; }
        public string Ponumber { get; set; }
        public string CellPhone { get; set; }
        public int? LeadTechnicianId { get; set; }
        public int? ProgrammerTechnicianId { get; set; }
        public decimal? ExpenseBudget { get; set; }
        public decimal? LaborBudget { get; set; }
        public decimal? CodingBudget { get; set; }
        public decimal? ProductBudget { get; set; }
        public decimal? ProductActual { get; set; }
        public DateTime? AccountingCloseDate { get; set; }
        public bool IsInvoiced { get; set; }
        public string QbcustomerListId { get; set; }
        public bool NeedsCableListTeam { get; set; }
        public bool NeedsDrawingsTeam { get; set; }
        public bool NeedsPurchasingTeam { get; set; }
        public bool NeedsCustomerRequirementsTeam { get; set; }
        public bool CableListTeamCompleted { get; set; }
        public bool DrawingsTeamCompleted { get; set; }
        public bool PurchasingTeamCompleted { get; set; }
        public bool CustomerRequirementsTeamCompleted { get; set; }
        public int? FromQuoteRevisionId { get; set; }
        public int? CreatedById { get; set; }
        public int? AccountingStatusId { get; set; }
        public string SignoffNotes { get; set; }
        public string SignoffSignature { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string SignoffSubmittedBy { get; set; }
        public int? FromLeadId { get; set; }
        public bool? LegacyServicePlan { get; set; }

        public virtual ProjectAccountingStatus AccountingStatus { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual LeadQuoteRevision FromQuoteRevision { get; set; }
        public virtual Employee LeadTechnician { get; set; }
        public virtual Employee ProgrammerTechnician { get; set; }
        public virtual ServicePlan ServicePlan { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<ItemComment> ItemComments { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<ItemFollower> ItemFollowers { get; set; }
        public virtual ICollection<ProjectAssignment> ProjectAssignments { get; set; }
        public virtual ICollection<ProjectMclproduct> ProjectMclproducts { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProducts { get; set; }
        public virtual ICollection<ProjectRoom> ProjectRooms { get; set; }
        public virtual ICollection<ProjectStartStopDate> ProjectStartStopDates { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
        public virtual ICollection<RoomServicePlan> RoomServicePlans { get; set; }
        public virtual ICollection<ThirdPartySupportContract> ThirdPartySupportContracts { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }
        public virtual ICollection<TroubleTicket> TroubleTickets { get; set; }
    }
}
