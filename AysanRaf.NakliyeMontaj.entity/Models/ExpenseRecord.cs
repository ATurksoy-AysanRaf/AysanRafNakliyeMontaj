using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ExpenseRecord
    {
        public string Id { get; set; } = null!;
        public string? An { get; set; }
        public decimal Price { get; set; }
        public string? AssetId { get; set; }
        public string? BillDate { get; set; }
        public string? BillNo { get; set; }
        public string? BillPartyId { get; set; }
        public string? BillPartyName { get; set; }
        public string? BillTypeId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Description { get; set; }
        public string? ExpenseTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public string? ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? SalesOrderId { get; set; }
        public string? ShipmentId { get; set; }
        public string? StateId { get; set; }
        public string? TaskActivityId { get; set; }
        public string? TaskId { get; set; }
        public string? TaskTypeId { get; set; }
        public string? TaskTypeTypeId { get; set; }
        public decimal TaxRate { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ExpenseRecordGroupId { get; set; }
        public string? InvoiceFileName { get; set; }
        public string? SalesOrderTitle { get; set; }
        public string? EmployeeId { get; set; }
        public string? InventoryItemId { get; set; }

        public virtual Asset? Asset { get; set; }
        public virtual Party? BillParty { get; set; }
        public virtual AspNetUser? Employee { get; set; }
        public virtual ExpenseRecordGroup? ExpenseRecordGroup { get; set; }
        public virtual ExpenseType? ExpenseType { get; set; }
        public virtual InventoryItem? InventoryItem { get; set; }
        public virtual Shipment? Shipment { get; set; }
        public virtual TaskActivity? TaskActivity { get; set; }
        public virtual TaskType? TaskType { get; set; }
    }
}
