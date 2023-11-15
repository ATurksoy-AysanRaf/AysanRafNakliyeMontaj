using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class PscategoryTaskType
    {
        public string Id { get; set; } = null!;
        public string? Condition { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int No { get; set; }
        public string? PscategoryId { get; set; }
        public string? PsfeatureId { get; set; }
        public string? StateId { get; set; }
        public string? TaskTypeId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Value { get; set; }
        public bool IsMileStone { get; set; }

        public virtual Psfeature? Psfeature { get; set; }
        public virtual TaskType? TaskType { get; set; }
    }
}
