using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ProcurementUserNotificationSetting
    {
        public string TenantId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public bool PurchaseOrderArrived { get; set; }
        public bool PurchaseOrderCreated { get; set; }
        public bool PurchaseOrderLate { get; set; }
        public bool RfqbidProvided { get; set; }
        public bool RfqbidRequested { get; set; }
        public bool RequestApproved { get; set; }
        public bool RequestCreated { get; set; }
        public bool RequestRejected { get; set; }

        public virtual Party Tenant { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
