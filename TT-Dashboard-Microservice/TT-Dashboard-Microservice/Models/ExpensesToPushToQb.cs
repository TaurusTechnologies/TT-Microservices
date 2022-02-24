using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ExpensesToPushToQb
    {
        public int ExpenseId { get; set; }
        public string ExpenseCode { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PersonalAmount { get; set; }
        public decimal? CompanyAmount { get; set; }
        public string Merchant { get; set; }
        public string Description { get; set; }
        public bool Billable { get; set; }
        public string EmployeeListId { get; set; }
        public string EmployeeCcref { get; set; }
        public bool? IsFixedAmount { get; set; }
        public decimal? DefaultAmount { get; set; }
        public bool IsMileage { get; set; }
        public string ExpenseAccountListId { get; set; }
        public string VendorListId { get; set; }
        public string PaymentTypeAccountListId { get; set; }
        public bool IsCompanyFunds { get; set; }
        public string AccountType { get; set; }
        public string ProjectCustomerListId { get; set; }
        public string CustomerCustomerListId { get; set; }
        public string LeadCustomerListId { get; set; }
        public string TtcustomerListId { get; set; }
    }
}
