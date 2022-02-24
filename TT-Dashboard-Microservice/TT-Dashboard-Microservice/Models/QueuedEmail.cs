using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class QueuedEmail
    {
        public int QueuedEmailId { get; set; }
        public string NotificationKey { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailTokens { get; set; }
        public int Status { get; set; }
        public DateTime DateQueued { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
