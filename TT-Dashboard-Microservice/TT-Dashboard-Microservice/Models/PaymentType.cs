using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Expenses = new HashSet<Expense>();
        }

        public int PaymentTypeId { get; set; }
        public string Name { get; set; }
        public bool? IsCompanyFunds { get; set; }
        public string QbaccountListId { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
