using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class EmploymentTaskType
    {
        public string EmployeeId { get; set; } = null!;
        public string TaskTypeId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLead { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser Employee { get; set; } = null!;
        public virtual TaskType TaskType { get; set; } = null!;
    }
}
