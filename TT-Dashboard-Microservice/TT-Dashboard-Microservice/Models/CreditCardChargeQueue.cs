using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class CreditCardChargeQueue
    {
        public int CreditCardChargeQueueId { get; set; }
        public string AccountRefListId { get; set; }
        public string PayeeEntityRefListId { get; set; }
        public DateTime? TxnDate { get; set; }
        public string Memo { get; set; }
        public string ExpenseLineAccountRefListId { get; set; }
        public decimal? ExpenseLineAmount { get; set; }
        public string ExpenseLineMemo { get; set; }
        public string ExpenseLineCustomerRefListId { get; set; }
        public string ExpenseLineBillableStatus { get; set; }
        public string ExpenseLineSalesRepRefListId { get; set; }
        public int? ExpenseId { get; set; }
        public string TxnId { get; set; }

        public virtual Expense Expense { get; set; }
    }
}
