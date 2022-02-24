using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class QbinvoiceStg
    {
        public string TxnId { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string TxnNumber { get; set; }
        public string CustomerListId { get; set; }
        public DateTime? TxnDate { get; set; }
        public string RefNumber { get; set; }
        public string Memo { get; set; }
        public string Ponumber { get; set; }
        public string TermsListId { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? IsPaid { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? SalesTaxTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? AppliedAmount { get; set; }
        public decimal? BalanceRemaining { get; set; }
        public string Other { get; set; }
    }
}
