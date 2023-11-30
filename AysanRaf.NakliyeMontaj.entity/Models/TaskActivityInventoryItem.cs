using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class TaskActivityInventoryItem
    {
        public string TaskActivityId { get; set; } = null!;
        public string InventoryItemId { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal Cost { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? TaskId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual InventoryItem InventoryItem { get; set; } = null!;
        public virtual Task? Task { get; set; }
        public virtual TaskActivity TaskActivity { get; set; } = null!;
    }
}
