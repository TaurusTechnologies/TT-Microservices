using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ZipLatLon
    {
        public int ZipLatLonId { get; set; }
        public string Zip { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
    }
}
