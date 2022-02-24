using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ScheduledEmail
    {
        public int ScheduledEmailId { get; set; }
        public string ProcedureName { get; set; }
        public DateTime? DailyStartTime { get; set; }
        public int? MaxMinutesBetweenEmails { get; set; }
        public DateTime? LastStart { get; set; }
        public DateTime? LastEnd { get; set; }
        public bool? Active { get; set; }
        public string EmailTo { get; set; }
    }
}
