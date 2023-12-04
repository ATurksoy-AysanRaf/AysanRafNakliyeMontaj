using System;
using System.Collections.Generic;

namespace Models
{
    public partial class FacilityStorage
    {
        public FacilityStorage()
        {
            InventoryItems = new HashSet<InventoryItem>();
            StockCountingActivities = new HashSet<StockCountingActivity>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public string? FacilityId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Note { get; set; }

        public virtual Facility? Facility { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<StockCountingActivity> StockCountingActivities { get; set; }
    }
}
