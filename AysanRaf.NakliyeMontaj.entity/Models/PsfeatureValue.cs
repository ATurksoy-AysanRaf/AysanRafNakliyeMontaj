using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PsfeatureValue
    {
        public string Psid { get; set; } = null!;
        public string PsfeatureId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Value { get; set; }

        public virtual Pss Ps { get; set; } = null!;
        public virtual Psfeature Psfeature { get; set; } = null!;
    }
}
