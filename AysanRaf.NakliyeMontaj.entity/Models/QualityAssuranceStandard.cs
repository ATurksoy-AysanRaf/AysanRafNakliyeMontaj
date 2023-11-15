using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class QualityAssuranceStandard
    {
        public QualityAssuranceStandard()
        {
            RelationPartyQascertificates = new HashSet<RelationPartyQascertificate>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; } = null!;
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? WebSiteUrl { get; set; }

        public virtual ICollection<RelationPartyQascertificate> RelationPartyQascertificates { get; set; }
    }
}
