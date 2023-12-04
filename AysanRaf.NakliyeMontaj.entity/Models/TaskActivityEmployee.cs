using System;
using System.Collections.Generic;

namespace Models
{
    public partial class TaskActivityEmployee
    {
        public string TaskActivityId { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public decimal Cost { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public string? StartDate { get; set; }
        public string? StateId { get; set; }
        public string? TaskId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser Employee { get; set; } = null!;
        public virtual Task? Task { get; set; }
        public virtual TaskActivity TaskActivity { get; set; } = null!;
    }
}
