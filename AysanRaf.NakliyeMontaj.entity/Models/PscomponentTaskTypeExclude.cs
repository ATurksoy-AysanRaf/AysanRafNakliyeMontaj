using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PscomponentTaskTypeExclude
    {
        public string TenantId { get; set; } = null!;
        public string Psid { get; set; } = null!;
        public string TaskTypeId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Pss Ps { get; set; } = null!;
        public virtual TaskType TaskType { get; set; } = null!;
    }
}
