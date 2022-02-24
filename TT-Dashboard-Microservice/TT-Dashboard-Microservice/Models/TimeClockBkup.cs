using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class TimeClockBkup
    {
        public int TimeClockId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public string ClockInMethod { get; set; }
        public string ClockOutMethod { get; set; }
        public decimal? ClockInLocationX { get; set; }
        public decimal? ClockInLocationY { get; set; }
        public decimal? ClockOutLocationX { get; set; }
        public decimal? ClockOutLocationY { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public string EditReason { get; set; }
        public DateTime? OriginalClockIn { get; set; }
        public DateTime? OriginalClockOut { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
    }
}
