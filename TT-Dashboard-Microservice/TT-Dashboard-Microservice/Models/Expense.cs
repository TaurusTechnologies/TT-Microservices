using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Expense
    {
        public Expense()
        {
            CreditCardChargeQueues = new HashSet<CreditCardChargeQueue>();
            ExpenseFiles = new HashSet<ExpenseFile>();
            ExpenseJournalEntryQueues = new HashSet<ExpenseJournalEntryQueue>();
            JournalEntryQueues = new HashSet<JournalEntryQueue>();
        }

        public int ExpenseId { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public int? ExpenseTypeId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PersonalAmount { get; set; }
        public string Description { get; set; }
        public string Merchant { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool? Reimbursable { get; set; }
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public int? ExpenseStatus { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? TroubleTicketId { get; set; }
        public decimal? CompanyAmount { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CustomerId { get; set; }
        public int? LeadId { get; set; }
        public string RejectReason { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? ApprovedByApOn { get; set; }
        public bool? PushedToQb { get; set; }
        public DateTime? PushedToQbon { get; set; }
        public string JournalEntryListId { get; set; }
        public string CreditCardChargeListId { get; set; }
        public bool IsActive { get; set; }
        public string ExpenseCode { get; set; }
        public decimal? Miles { get; set; }
        public string Vendor { get; set; }
        public DateTime? RejectionDate { get; set; }

        public virtual Employee ApprovedByNavigation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
        public virtual Lead Lead { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Project Project { get; set; }
        public virtual TroubleTicket TroubleTicket { get; set; }
        public virtual ICollection<CreditCardChargeQueue> CreditCardChargeQueues { get; set; }
        public virtual ICollection<ExpenseFile> ExpenseFiles { get; set; }
        public virtual ICollection<ExpenseJournalEntryQueue> ExpenseJournalEntryQueues { get; set; }
        public virtual ICollection<JournalEntryQueue> JournalEntryQueues { get; set; }
    }
}
