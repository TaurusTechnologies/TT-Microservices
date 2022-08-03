using System;

namespace TT_Dashboard_Microservice.Models.Dtos.Project
{
    public class ProjectProductDto
    {
        public bool received { get; set; }
        public int projectProductId { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public int quantity { get; set; }
        public string binNumber { get; set; }
        public string vendor { get; set; }
        public string trackingNumber { get; set; }
        public decimal? quotePrice { get; set; }
        public decimal? price { get; set; }
        public string manufacturer { get; set; }
        public string partNumber { get; set; }
        public DateTime? eta { get; set; }
        public string poNumber { get; set; }
        public string orderNotes { get; set; }

    }
}