using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class CalendarEvent
    {
        public int CalendarEventId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public bool? IsHoliday { get; set; }
    }
}
