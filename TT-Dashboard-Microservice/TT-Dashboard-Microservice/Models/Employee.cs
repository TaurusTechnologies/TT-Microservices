using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Employee
    {
        public Employee()
        {
            CustomerSalespeople = new HashSet<CustomerSalesperson>();
            EmployeeExpirationItems = new HashSet<EmployeeExpirationItem>();
            ExpenseApprovedByNavigations = new HashSet<Expense>();
            ExpenseEmployees = new HashSet<Expense>();
            ExpenseFiles = new HashSet<ExpenseFile>();
            InverseManager = new HashSet<Employee>();
            ItemComments = new HashSet<ItemComment>();
            ItemFileEmployeeDocuments = new HashSet<ItemFile>();
            ItemFileEmployees = new HashSet<ItemFile>();
            ItemFollowUps = new HashSet<ItemFollowUp>();
            ItemFollowers = new HashSet<ItemFollower>();
            LeadAssignments = new HashSet<LeadAssignment>();
            LeadCreatedBies = new HashSet<Lead>();
            LeadDesignApprovers = new HashSet<Lead>();
            LeadPricingApprovers = new HashSet<Lead>();
            LeadQuoteRevisionAssignments = new HashSet<LeadQuoteRevisionAssignment>();
            ProjectAssignments = new HashSet<ProjectAssignment>();
            ProjectCreatedBies = new HashSet<Project>();
            ProjectLeadTechnicians = new HashSet<Project>();
            ProjectMclproductOrderedByEmployees = new HashSet<ProjectMclproduct>();
            ProjectMclproductReceivedByEmployees = new HashSet<ProjectMclproduct>();
            ProjectProductOrderedByEmployees = new HashSet<ProjectProduct>();
            ProjectProductReceivedByEmployees = new HashSet<ProjectProduct>();
            ProjectProductReceiveds = new HashSet<ProjectProductReceived>();
            ProjectProgrammerTechnicians = new HashSet<Project>();
            ProjectTaskAssignments = new HashSet<ProjectTaskAssignment>();
            PtorequestApproverNavigations = new HashSet<Ptorequest>();
            PtorequestEmployees = new HashSet<Ptorequest>();
            PtorequestModifiedByNavigations = new HashSet<Ptorequest>();
            TeamMembers = new HashSet<TeamMember>();
            TimeClocks = new HashSet<TimeClock>();
            TimeLogs = new HashSet<TimeLog>();
            TroubleTicketAssignments = new HashSet<TroubleTicketAssignment>();
        }

        public int EmployeeId { get; set; }
        public string SamaccountName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string Department { get; set; }
        public string TelephoneNumber { get; set; }
        public string DistinguishedName { get; set; }
        public string ManagerDn { get; set; }
        public int? ManagerId { get; set; }
        public string QbcreditCardRef { get; set; }
        public string QbemployeeListId { get; set; }
        public bool? IsTech { get; set; }
        public string MandEqbaccountListId { get; set; }
        public int? LocationId { get; set; }
        public string MiscName1 { get; set; }
        public string MiscValue1 { get; set; }
        public string MiscName2 { get; set; }
        public string MiscValue2 { get; set; }
        public string MiscName3 { get; set; }
        public string MiscValue3 { get; set; }
        public string MiscName4 { get; set; }
        public string MiscValue4 { get; set; }
        public string MiscName5 { get; set; }
        public string MiscValue5 { get; set; }
        public string MiscName6 { get; set; }
        public string MiscValue6 { get; set; }
        public string MiscName7 { get; set; }
        public string MiscValue7 { get; set; }
        public string MiscName8 { get; set; }
        public string MiscValue8 { get; set; }
        public string MiscName9 { get; set; }
        public string MiscValue9 { get; set; }
        public string MiscName10 { get; set; }
        public DateTime? BirthDay { get; set; }
        public string MiscValue10 { get; set; }
        public string MiddleName { get; set; }
        public bool? TrackTime { get; set; }
        public string RegularPayListId { get; set; }
        public string OvertimePayListId { get; set; }
        public string PtopayListId { get; set; }
        public string HolidayPayListId { get; set; }
        public string HolidayPayPayListId { get; set; }
        public int? PurchaseTeamId { get; set; }
        public bool? PushTimeToQuickbooks { get; set; }
        public int? CommissionGrossProfit { get; set; }
        public int? CommissionBlueRibbon { get; set; }
        public string JuryDutyPayListId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual Team PurchaseTeam { get; set; }
        public virtual ICollection<CustomerSalesperson> CustomerSalespeople { get; set; }
        public virtual ICollection<EmployeeExpirationItem> EmployeeExpirationItems { get; set; }
        public virtual ICollection<Expense> ExpenseApprovedByNavigations { get; set; }
        public virtual ICollection<Expense> ExpenseEmployees { get; set; }
        public virtual ICollection<ExpenseFile> ExpenseFiles { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<ItemComment> ItemComments { get; set; }
        public virtual ICollection<ItemFile> ItemFileEmployeeDocuments { get; set; }
        public virtual ICollection<ItemFile> ItemFileEmployees { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<ItemFollower> ItemFollowers { get; set; }
        public virtual ICollection<LeadAssignment> LeadAssignments { get; set; }
        public virtual ICollection<Lead> LeadCreatedBies { get; set; }
        public virtual ICollection<Lead> LeadDesignApprovers { get; set; }
        public virtual ICollection<Lead> LeadPricingApprovers { get; set; }
        public virtual ICollection<LeadQuoteRevisionAssignment> LeadQuoteRevisionAssignments { get; set; }
        public virtual ICollection<ProjectAssignment> ProjectAssignments { get; set; }
        public virtual ICollection<Project> ProjectCreatedBies { get; set; }
        public virtual ICollection<Project> ProjectLeadTechnicians { get; set; }
        public virtual ICollection<ProjectMclproduct> ProjectMclproductOrderedByEmployees { get; set; }
        public virtual ICollection<ProjectMclproduct> ProjectMclproductReceivedByEmployees { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProductOrderedByEmployees { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProductReceivedByEmployees { get; set; }
        public virtual ICollection<ProjectProductReceived> ProjectProductReceiveds { get; set; }
        public virtual ICollection<Project> ProjectProgrammerTechnicians { get; set; }
        public virtual ICollection<ProjectTaskAssignment> ProjectTaskAssignments { get; set; }
        public virtual ICollection<Ptorequest> PtorequestApproverNavigations { get; set; }
        public virtual ICollection<Ptorequest> PtorequestEmployees { get; set; }
        public virtual ICollection<Ptorequest> PtorequestModifiedByNavigations { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<TimeClock> TimeClocks { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }
        public virtual ICollection<TroubleTicketAssignment> TroubleTicketAssignments { get; set; }
    }
}
