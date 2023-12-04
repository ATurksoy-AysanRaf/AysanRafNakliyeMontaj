using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ProcurementRfq
    {
        public ProcurementRfq()
        {
            ProcurementPurchaseOrders = new HashSet<ProcurementPurchaseOrder>();
            ProcurementRfqbids = new HashSet<ProcurementRfqbid>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DeadlineDateRfq { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? DocumentName { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual ICollection<ProcurementPurchaseOrder> ProcurementPurchaseOrders { get; set; }
        public virtual ICollection<ProcurementRfqbid> ProcurementRfqbids { get; set; }
    }
}
