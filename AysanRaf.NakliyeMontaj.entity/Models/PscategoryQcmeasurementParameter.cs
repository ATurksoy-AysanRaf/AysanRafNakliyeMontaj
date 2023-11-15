using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class PscategoryQcmeasurementParameter
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public short DisplayOrder { get; set; }
        public string? Instructions { get; set; }
        public bool IsDeleted { get; set; }
        public decimal MaxTolerance { get; set; }
        public decimal MinTolerance { get; set; }
        public string? Name { get; set; }
        public string? PscategoryId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UnitId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
    }
}
