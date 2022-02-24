using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class LeadType
    {
        public LeadType()
        {
            Leads = new HashSet<Lead>();
        }

        public int LeadTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lead> Leads { get; set; }
    }
}
