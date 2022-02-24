using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            Expenses = new HashSet<Expense>();
        }

        public int ExpenseTypeId { get; set; }
        public string ExpenseName { get; set; }
        public decimal? DefaultAmount { get; set; }
        public bool? IsFixedAmount { get; set; }
        public string QbaccountListId { get; set; }
        public string QbvendorListId { get; set; }
        public bool IsMileage { get; set; }
        public decimal? MileageAmount { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
