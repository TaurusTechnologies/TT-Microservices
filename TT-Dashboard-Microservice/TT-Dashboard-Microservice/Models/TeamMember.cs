using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class TeamMember
    {
        public int TeamMemberId { get; set; }
        public int TeamId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Team Team { get; set; }
    }
}
