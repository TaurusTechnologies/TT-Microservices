using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ProjectRoom
    {
        public ProjectRoom()
        {
            ProjectProducts = new HashSet<ProjectProduct>();
        }

        public int ProjectRoomId { get; set; }
        public int ProjectId { get; set; }
        public int RoomId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Project Project { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProducts { get; set; }
    }
}
