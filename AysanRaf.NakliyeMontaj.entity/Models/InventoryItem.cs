using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class InventoryItem
    {
        public InventoryItem()
        {
            Assets = new HashSet<Asset>();
            ExpenseRecords = new HashSet<ExpenseRecord>();
            InventoryItemTransactions = new HashSet<InventoryItemTransaction>();
            ShipmentItems = new HashSet<ShipmentItem>();
            StockCountingActivityItems = new HashSet<StockCountingActivityItem>();
            TaskActivityInventoryItems = new HashSet<TaskActivityInventoryItem>();
        }

        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Expiration { get; set; }
        public string? FacilityId { get; set; }
        public string? FacilityStorageId { get; set; }
        public bool IsDeleted { get; set; }
        public string? LotId { get; set; }
        public string? ShipmentTaskId { get; set; }
        public string? PurchaseOrderItemId { get; set; }
        public string? Received { get; set; }
        public string? SalesOrderId { get; set; }
        public string? Serial { get; set; }
        public string? StateId { get; set; }
        public string? StockTaskId { get; set; }
        public string? SupplierBarCode { get; set; }
        public string? SupplierId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? PscategoryId { get; set; }
        public string? Note { get; set; }
        public string? Psid { get; set; }
        public string? No { get; set; }
        public string? ProjectId { get; set; }
        public string? PurchaseOrderId { get; set; }
        public string? Floor { get; set; }
        public string? Column { get; set; }
        public string? Row { get; set; }
        public string? Shelf { get; set; }
        public string? Section { get; set; }
        public string? SalesOrderItemId { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? CustomerName { get; set; }
        public string? ProjectName { get; set; }
        public string? Psn { get; set; }
        public string? PurchaseUnit { get; set; }
        public string? SupplierName { get; set; }
        public string? Currency { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Height { get; set; }
        public string? ParentId { get; set; }
        public string? ConditionId { get; set; }
        public string? SupplierQccode { get; set; }
        public string? SupplierQcitemNo { get; set; }
        public string? SupplierQcmainNo { get; set; }
        public string? SupplierWayBillNo { get; set; }
        public string? TypeId { get; set; }
        public decimal WeightCase { get; set; }
        public decimal WeightNet { get; set; }

        public virtual Facility? Facility { get; set; }
        public virtual FacilityStorage? FacilityStorage { get; set; }
        public virtual Project? Project { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual ProcurementPurchaseOrder? PurchaseOrder { get; set; }
        public virtual ProcurementPurchaseOrderItem? PurchaseOrderItem { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual SalesOrderItem? SalesOrderItem { get; set; }
        public virtual Task? ShipmentTask { get; set; }
        public virtual Task? StockTask { get; set; }
        public virtual Party? Supplier { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<InventoryItemTransaction> InventoryItemTransactions { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<StockCountingActivityItem> StockCountingActivityItems { get; set; }
        public virtual ICollection<TaskActivityInventoryItem> TaskActivityInventoryItems { get; set; }
    }
}
