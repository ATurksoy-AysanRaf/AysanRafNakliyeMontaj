using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ProcurementPurchaseOrderItem
    {
        public ProcurementPurchaseOrderItem()
        {
            InventoryItems = new HashSet<InventoryItem>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DescriptionPurchaseOrderItem { get; set; }
        public bool IsDeleted { get; set; }
        public string? PscategoryId { get; set; }
        public string? ProcurementPurchaseOrderId { get; set; }
        public string? ProcurementRfqbidId { get; set; }
        public string? ProcurementRfqbidItemId { get; set; }
        public string? ProcurementRfqid { get; set; }
        public string? ProcurementRequestId { get; set; }
        public string? StateId { get; set; }
        public string? SupplierId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public decimal AmountOrder { get; set; }
        public string Psid { get; set; } = null!;
        public decimal AmountOrderRemaining { get; set; }
        public string? Currency { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal UnitPrice { get; set; }
        public string? SupplierName { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? CustomerName { get; set; }
        public string? PurchaseUnit { get; set; }
        public string? Psn { get; set; }
        public string? BrandName { get; set; }
        public string? Model { get; set; }
        public string? DeliveryDatePossible { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeadlineDateRequest { get; set; }
        public decimal UnitPriceDiscounted { get; set; }

        public virtual ProcurementPurchaseOrder? ProcurementPurchaseOrder { get; set; }
        public virtual ProcurementRequest? ProcurementRequest { get; set; }
        public virtual ProcurementRfqbidItem? ProcurementRfqbidItem { get; set; }
        public virtual Pss Ps { get; set; } = null!;
        public virtual Pscategory? Pscategory { get; set; }
        public virtual Party? Supplier { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    }
}
