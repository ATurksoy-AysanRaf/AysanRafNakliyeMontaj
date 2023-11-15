using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class InAppNotification
    {
        public string Id { get; set; } = null!;
        public string? AppServiceName { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Message { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? Title { get; set; }
        public string? ToUserId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ActionName { get; set; }
        public string? ResourceUrl { get; set; }
        public string? Url { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual AspNetUser? ToUser { get; set; }
    }
}
