using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ProcurementPurchaseOrderWayBillDocument
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public int DisplayOrder { get; set; }
        public string? FileName { get; set; }
        public bool IsDeleted { get; set; }
        public int MediaType { get; set; }
        public string? ProcurementPurchaseOrderId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? WayBillNumber { get; set; }

        public virtual ProcurementPurchaseOrder? ProcurementPurchaseOrder { get; set; }
    }
}
