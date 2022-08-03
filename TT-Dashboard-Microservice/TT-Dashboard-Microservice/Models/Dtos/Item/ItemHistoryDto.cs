using System;

namespace TT_Dashboard_Microservice.Models.Dtos.Item
{
    public class ItemHistoryDto
    {
        public int id { get; set; }
        public int type { get; set; }
        public string message { get; set; }
        public string author { get; set; }
        public int authorId { get; set; }
        public string timeStamp { get; set; }
    }
}