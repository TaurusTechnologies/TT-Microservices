﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class VwAspnetProfile
    {
        public Guid UserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int? DataSize { get; set; }
    }
}
