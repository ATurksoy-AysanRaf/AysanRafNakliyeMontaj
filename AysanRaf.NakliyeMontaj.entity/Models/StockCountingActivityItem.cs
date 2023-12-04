using System;
using System.Collections.Generic;

namespace Models
{
    public partial class StockCountingActivityItem
    {
        public string StockCountingActivityId { get; set; } = null!;
        public string InventoryItemId { get; set; } = null!;
        public decimal AmountFinal { get; set; }
        public decimal AmountInitial { get; set; }
        public string? CheckedDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? InventoryItemNo { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual InventoryItem InventoryItem { get; set; } = null!;
        public virtual StockCountingActivity StockCountingActivity { get; set; } = null!;
    }
}
