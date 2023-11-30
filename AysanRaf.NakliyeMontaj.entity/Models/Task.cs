using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Task
    {
        public Task()
        {
            InventoryItemShipmentTasks = new HashSet<InventoryItem>();
            InventoryItemStockTasks = new HashSet<InventoryItem>();
            InverseTaskNavigation = new HashSet<Task>();
            ShipmentItems = new HashSet<ShipmentItem>();
            TaskActivities = new HashSet<TaskActivity>();
            TaskActivityAssets = new HashSet<TaskActivityAsset>();
            TaskActivityEmployees = new HashSet<TaskActivityEmployee>();
            TaskActivityInventoryItems = new HashSet<TaskActivityInventoryItem>();
            TaskNotes = new HashSet<TaskNote>();
        }

        public string Id { get; set; } = null!;
        public decimal Acost { get; set; }
        public int Aduration { get; set; }
        public string? Aend { get; set; }
        public string? Astart { get; set; }
        public decimal AmountDefective { get; set; }
        public decimal AmountDone { get; set; }
        public decimal AmountRequired { get; set; }
        public decimal AmountToDo { get; set; }
        public string? AssetId { get; set; }
        public string? UserId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? PscomponentId { get; set; }
        public string? Psid { get; set; }
        public decimal Pcost { get; set; }
        public int Pduration { get; set; }
        public string? Pend { get; set; }
        public string? Pstart { get; set; }
        public string? ProjectId { get; set; }
        public string? RevReason { get; set; }
        public string? RevParty { get; set; }
        public string? RevType { get; set; }
        public string? SalesOrderId { get; set; }
        public string? SalesOrderItemComponentId { get; set; }
        public string? SalesOrderItemId { get; set; }
        public int Sno { get; set; }
        public string? StateId { get; set; }
        public string? TaskId { get; set; }
        public string? TaskTypeId { get; set; }
        public string? TenantId { get; set; }
        public string? Title { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? No { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? CustomerName { get; set; }
        public string? ProjectName { get; set; }
        public string? An { get; set; }
        public string? Pscn { get; set; }
        public string? Psn { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CustomerId { get; set; }
        public string? Town { get; set; }

        public virtual Asset? Asset { get; set; }
        public virtual Project? Project { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pss? Pscomponent { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual SalesOrderItem? SalesOrderItem { get; set; }
        public virtual SalesOrderItemComponent? SalesOrderItemComponent { get; set; }
        public virtual Task? TaskNavigation { get; set; }
        public virtual TaskType? TaskType { get; set; }
        public virtual AspNetUser? User { get; set; }
        public virtual ICollection<InventoryItem> InventoryItemShipmentTasks { get; set; }
        public virtual ICollection<InventoryItem> InventoryItemStockTasks { get; set; }
        public virtual ICollection<Task> InverseTaskNavigation { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<TaskActivity> TaskActivities { get; set; }
        public virtual ICollection<TaskActivityAsset> TaskActivityAssets { get; set; }
        public virtual ICollection<TaskActivityEmployee> TaskActivityEmployees { get; set; }
        public virtual ICollection<TaskActivityInventoryItem> TaskActivityInventoryItems { get; set; }
        public virtual ICollection<TaskNote> TaskNotes { get; set; }
    }
}
