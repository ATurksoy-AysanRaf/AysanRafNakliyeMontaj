using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class Pscomponent
    {
        public string TenantId { get; set; } = null!;
        public string Psid { get; set; } = null!;
        public string ComponentId { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? TypeId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Pss Component { get; set; } = null!;
        public virtual Pss Ps { get; set; } = null!;
        public virtual Party Tenant { get; set; } = null!;
    }
}
