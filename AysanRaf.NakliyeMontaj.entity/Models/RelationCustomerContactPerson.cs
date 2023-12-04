using System;
using System.Collections.Generic;

namespace Models
{
    public partial class RelationCustomerContactPerson
    {
        public string TenantId { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string ContactId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Party Contact { get; set; } = null!;
        public virtual Party Customer { get; set; } = null!;
        public virtual Party Tenant { get; set; } = null!;
    }
}
