using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class PriceCalculation
    {
        public int PriceCalculationId { get; set; }
        public int ProductId { get; set; }
        public string ProductTypes { get; set; }
        public decimal UpperBound1 { get; set; }
        public decimal UpperBound2 { get; set; }
        public decimal Percent1 { get; set; }
        public decimal Percent2 { get; set; }
        public decimal Percent3 { get; set; }

        public virtual Product Product { get; set; }
    }
}
