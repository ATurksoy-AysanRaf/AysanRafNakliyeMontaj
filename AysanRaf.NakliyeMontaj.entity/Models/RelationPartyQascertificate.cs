using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class RelationPartyQascertificate
    {
        public string Id { get; set; } = null!;
        public string? AccreditorId { get; set; }
        public string? CertificateId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? PartyId { get; set; }
        public string? PublicationDate { get; set; }
        public string? RegistrarId { get; set; }
        public string? ScopeEnglish { get; set; }
        public string? ScopePrimaryLanguage { get; set; }
        public string? StandardId { get; set; }
        public string? StartedDate { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Party? Accreditor { get; set; }
        public virtual Party? Party { get; set; }
        public virtual Party? Registrar { get; set; }
        public virtual QualityAssuranceStandard? Standard { get; set; }
    }
}
