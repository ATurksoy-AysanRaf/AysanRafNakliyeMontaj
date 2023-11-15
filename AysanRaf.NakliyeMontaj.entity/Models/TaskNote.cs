using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class TaskNote
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Note { get; set; }
        public string? StateId { get; set; }
        public string? TaskId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Task? Task { get; set; }
    }
}
