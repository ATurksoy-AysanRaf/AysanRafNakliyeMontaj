using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class InventoryPsstockLevelConstraint
    {
        public string TenantId { get; set; } = null!;
        public string Psid { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Max { get; set; }
        public decimal Min { get; set; }
        public string? StateId { get; set; }
        public string? Unit { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Pss Ps { get; set; } = null!;
    }
}
