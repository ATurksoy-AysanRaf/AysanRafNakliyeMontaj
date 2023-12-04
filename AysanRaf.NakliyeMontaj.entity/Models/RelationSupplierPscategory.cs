using System;
using System.Collections.Generic;

namespace Models
{
    public partial class RelationSupplierPscategory
    {
        public string SupplierId { get; set; } = null!;
        public string PscategoryId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Pscategory Pscategory { get; set; } = null!;
        public virtual Party Supplier { get; set; } = null!;
    }
}
