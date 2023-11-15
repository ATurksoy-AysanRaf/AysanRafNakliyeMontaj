using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class ProcurementRequestMedia
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
        public string? FileName { get; set; }
        public bool IsDeleted { get; set; }
        public int MediaType { get; set; }
        public string? ProcurementRequestId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ContentType { get; set; }
        public string? UsageType { get; set; }

        public virtual ProcurementRequest? ProcurementRequest { get; set; }
    }
}
