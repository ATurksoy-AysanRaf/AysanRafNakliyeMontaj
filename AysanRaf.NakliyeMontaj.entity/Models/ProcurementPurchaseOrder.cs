using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ProcurementPurchaseOrder
    {
        public ProcurementPurchaseOrder()
        {
            InventoryItems = new HashSet<InventoryItem>();
            ProcurementPurchaseOrderItems = new HashSet<ProcurementPurchaseOrderItem>();
            ProcurementPurchaseOrderWayBillDocuments = new HashSet<ProcurementPurchaseOrderWayBillDocument>();
            ShipmentAmountBasedPlans = new HashSet<ShipmentAmountBasedPlan>();
            Shipments = new HashSet<Shipment>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? ProcurementRfqbidId { get; set; }
        public string? ProcurementRfqid { get; set; }
        public string? StateId { get; set; }
        public string? SupplierId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? DescriptionPurchaseOrder { get; set; }
        public string? PurposePurchaseOrder { get; set; }
        public string? DocumentName { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual ProcurementRfq? ProcurementRfq { get; set; }
        public virtual ProcurementRfqbid? ProcurementRfqbid { get; set; }
        public virtual Party? Supplier { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderWayBillDocument> ProcurementPurchaseOrderWayBillDocuments { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlans { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
