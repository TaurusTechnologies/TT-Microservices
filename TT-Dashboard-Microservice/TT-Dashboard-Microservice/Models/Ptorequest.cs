using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Ptorequest
    {
        public Ptorequest()
        {
            ItemFollowUps = new HashSet<ItemFollowUp>();
            PtorequestDays = new HashSet<PtorequestDay>();
        }

        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
        public int StatusId { get; set; }
        public string Notes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Approver { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool Active { get; set; }
        public int ModifiedBy { get; set; }
        public byte[] ModifiedDate { get; set; }
        public string RejectionReason { get; set; }
        public bool IsHalfDay { get; set; }
        public bool IsJuryDuty { get; set; }
        public DateTime? RejectionDate { get; set; }
        public DateTime? RequestedOnDate { get; set; }

        public virtual Employee ApproverNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee ModifiedByNavigation { get; set; }
        public virtual Ptostatus Status { get; set; }
        public virtual ICollection<ItemFollowUp> ItemFollowUps { get; set; }
        public virtual ICollection<PtorequestDay> PtorequestDays { get; set; }
    }
}
