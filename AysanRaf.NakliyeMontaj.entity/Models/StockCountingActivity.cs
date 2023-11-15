using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class StockCountingActivity
    {
        public StockCountingActivity()
        {
            StockCountingActivityItems = new HashSet<StockCountingActivityItem>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? EndDate { get; set; }
        public string? FacilityId { get; set; }
        public string? FacilityStorageId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StartDate { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Facility? Facility { get; set; }
        public virtual FacilityStorage? FacilityStorage { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<StockCountingActivityItem> StockCountingActivityItems { get; set; }
    }
}
