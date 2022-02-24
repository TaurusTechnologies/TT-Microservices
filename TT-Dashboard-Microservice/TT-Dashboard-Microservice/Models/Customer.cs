using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerDocumentTrackings = new HashSet<CustomerDocumentTracking>();
            CustomerSalespeople = new HashSet<CustomerSalesperson>();
            Expenses = new HashSet<Expense>();
            InverseParentCustomer = new HashSet<Customer>();
            ItemComments = new HashSet<ItemComment>();
            ItemFiles = new HashSet<ItemFile>();
            ItemFollowUps = new HashSet<ItemFollowUp>();
            ItemFollowers = new HashSet<ItemFollower>();
            Leads = new HashSet<Lead>();
            Projects = new HashSet<Project>();
            Rooms = new HashSet<Room>();
            TimeLogs = new HashSet<TimeLog>();
            TroubleTickets = new HashSet<TroubleTicket>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int? ParentCustomerId { get; set; }
        public int Status { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public string Notes { get; set; }
        public string ContactRole { get; set; }
        public string Industry { get; set; }
        public string Source { get; set; }
        public int? TeamId { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public string BillingContactName { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingFaxNumber { get; set; }
        public string CellPhone { get; set; }
        public string BillingEmail { get; set; }
        public string Terms { get; set; }
        public bool? ServiceNotificationExemption { get; set; }
        public int? IndustryTypeId { get; set; }
        public string QbcustomerListId { get; set; }
        public byte[] CustomerLogo { get; set; }
        public byte[] Logo { get; set; }

        public virtual IndustryType IndustryType { get; set; }
        public virtual Customer ParentCustomer { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<CustomerDocumentTracking> CustomerDocumentTrackings { get; set; }
        public virtual ICollection<CustomerSalesperson> CustomerSalespeople { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Customer> InverseParentCustomer { get; set; }
        public virtual ICollection<ItemComment> ItemComments { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<ItemFollower> ItemFollowers { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }
        public virtual ICollection<TroubleTicket> TroubleTickets { get; set; }
    }
}
