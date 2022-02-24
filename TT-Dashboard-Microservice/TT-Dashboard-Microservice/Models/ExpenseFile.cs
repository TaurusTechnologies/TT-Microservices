using System;
using System.Collections.Generic;

#nullable disable

namespace TT_Dashboard_Microservice.Models
{
    public partial class ExpenseFile
    {
        public int ExpenseFileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public bool? IsImage { get; set; }
        public string Path { get; set; }
        public string ThumbnailPath { get; set; }
        public int Size { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime Timestamp { get; set; }
        public int? ExpenseId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Expense Expense { get; set; }
    }
}
