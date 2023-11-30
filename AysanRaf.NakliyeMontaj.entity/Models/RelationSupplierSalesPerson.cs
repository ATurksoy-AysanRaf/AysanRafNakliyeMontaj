using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class RelationSupplierSalesPerson
    {
        public string TenantId { get; set; } = null!;
        public string SupplierId { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Title { get; set; }

        public virtual Party Employee { get; set; } = null!;
        public virtual Party Supplier { get; set; } = null!;
        public virtual Party Tenant { get; set; } = null!;
    }
}
