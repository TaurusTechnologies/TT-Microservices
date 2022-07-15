using System;

namespace TT_Dashboard_Microservice.Models.Dtos
{
    public class ProjectStartStopDateDto
    {
        public int ProjectStartStopDateId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}