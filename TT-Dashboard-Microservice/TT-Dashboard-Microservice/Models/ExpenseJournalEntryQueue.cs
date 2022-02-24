using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ExpenseJournalEntryQueue
    {
        public int ExpenseJournalEntryId { get; set; }
        public int? ExpenseId { get; set; }
        public bool? IsPosted { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? TxnDate { get; set; }
        public string ProjectCode { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsDebit { get; set; }
        public decimal? Amount { get; set; }
        public string Memo { get; set; }
        public string BillableStatus { get; set; }
        public string QbcustomerListId { get; set; }

        public virtual Expense Expense { get; set; }
    }
}
