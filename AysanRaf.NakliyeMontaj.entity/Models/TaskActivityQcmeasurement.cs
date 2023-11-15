using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class TaskActivityQcmeasurement
    {
        public string Id { get; set; } = null!;
        public string? An { get; set; }
        public string? AssetId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CustomerName { get; set; }
        public bool IsDeleted { get; set; }
        public string? Pms { get; set; }
        public string? Psid { get; set; }
        public string? Psn { get; set; }
        public string? ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? SalesOrderId { get; set; }
        public string? StateId { get; set; }
        public string? TaskActivityId { get; set; }
        public string? TaskId { get; set; }
        public string? TaskTypeId { get; set; }
        public string? TaskTypeTypeId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual TaskActivity? TaskActivity { get; set; }
        public virtual TaskType? TaskType { get; set; }
    }
}
