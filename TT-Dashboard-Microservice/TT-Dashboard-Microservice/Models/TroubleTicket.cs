using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class TroubleTicket
    {
        public TroubleTicket()
        {
            Expenses = new HashSet<Expense>();
            ItemComments = new HashSet<ItemComment>();
            ItemFiles = new HashSet<ItemFile>();
            ItemFollowUps = new HashSet<ItemFollowUp>();
            ItemFollowers = new HashSet<ItemFollower>();
            TimeLogs = new HashSet<TimeLog>();
            TroubleTicketAssignments = new HashSet<TroubleTicketAssignment>();
            TroubleTicketDueDates = new HashSet<TroubleTicketDueDate>();
            TroubleTicketRooms = new HashSet<TroubleTicketRoom>();
        }

        public int TroubleTicketId { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public int? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? LeadId { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime? DateClosed { get; set; }
        public int? TeamId { get; set; }
        public string ProjectCode { get; set; }
        public DateTime? DateDue { get; set; }
        public int Priority { get; set; }
        public bool? IsBillable { get; set; }
        public DateTime? AccountingCloseDate { get; set; }
        public bool IsInvoiced { get; set; }
        public string QbcustomerListId { get; set; }
        public string SignoffNotes { get; set; }
        public string SignoffSignature { get; set; }
        public string SignoffSubmittedBy { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Lead Lead { get; set; }
        public virtual Project Project { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<ItemComment> ItemComments { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<ItemFollower> ItemFollowers { get; set; }
        public virtual ICollection<TimeLog> TimeLogs { get; set; }
        public virtual ICollection<TroubleTicketAssignment> TroubleTicketAssignments { get; set; }
        public virtual ICollection<TroubleTicketDueDate> TroubleTicketDueDates { get; set; }
        public virtual ICollection<TroubleTicketRoom> TroubleTicketRooms { get; set; }
    }
}
