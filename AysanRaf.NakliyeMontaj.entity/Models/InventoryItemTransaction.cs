using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class InventoryItemTransaction
    {
        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? InventoryItemId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Note { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual InventoryItem? InventoryItem { get; set; }
        public virtual Party? Tenant { get; set; }
    }
}
