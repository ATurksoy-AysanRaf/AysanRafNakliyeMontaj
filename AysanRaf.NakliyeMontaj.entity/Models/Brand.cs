using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Psses = new HashSet<Pss>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Party? Tenant { get; set; }
        public virtual ICollection<Pss> Psses { get; set; }
    }
}
