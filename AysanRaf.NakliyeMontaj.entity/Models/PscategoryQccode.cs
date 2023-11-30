using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class PscategoryQccode
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public short DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; } = null!;
        public string? PscategoryId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
    }
}
