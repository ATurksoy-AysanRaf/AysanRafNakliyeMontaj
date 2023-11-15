using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class OrganizationDetail
    {
        public string OrganizationId { get; set; } = null!;
        public string? DateClosed { get; set; }
        public string? DateEstablished { get; set; }
        public string? NameOriginalLanguage { get; set; }
        public string? NameRegisteredTrademark { get; set; }

        public virtual Party Organization { get; set; } = null!;
    }
}
