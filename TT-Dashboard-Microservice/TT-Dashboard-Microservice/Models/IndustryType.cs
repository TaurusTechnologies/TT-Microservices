using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class IndustryType
    {
        public IndustryType()
        {
            Customers = new HashSet<Customer>();
            Leads = new HashSet<Lead>();
        }

        public int IndustryTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
    }
}
