using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class Room
    {
        public Room()
        {
            ItemFiles = new HashSet<ItemFile>();
            ProjectRooms = new HashSet<ProjectRoom>();
            RevisionRooms = new HashSet<RevisionRoom>();
            RoomServicePlans = new HashSet<RoomServicePlan>();
            TroubleTicketRooms = new HashSet<TroubleTicketRoom>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int CustomerId { get; set; }
        public string Location { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Sowsummary { get; set; }
        public string SowkeyComponents { get; set; }
        public string SowclientRequirements { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ProjectRoom> ProjectRooms { get; set; }
        public virtual ICollection<RevisionRoom> RevisionRooms { get; set; }
        public virtual ICollection<RoomServicePlan> RoomServicePlans { get; set; }
        public virtual ICollection<TroubleTicketRoom> TroubleTicketRooms { get; set; }
    }
}
