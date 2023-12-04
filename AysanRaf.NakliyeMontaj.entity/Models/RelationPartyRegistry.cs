using System;
using System.Collections.Generic;

namespace Models
{
    public partial class RelationPartyRegistry
    {
        public string PartyId { get; set; } = null!;
        public string RegistrarId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRegistrationValidated { get; set; }
        public string? RegistrarCode { get; set; }
        public string? RegistrationIdCode { get; set; }
        public string? RegistrationValidatedUserId { get; set; }
        public string? RegistrationValidationDate { get; set; }
        public string? RegistrationValidationMethod { get; set; }
        public string? RegistrationValidationUrl { get; set; }
        public string? StateId { get; set; }
        public string TypeId { get; set; } = null!;
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Party Party { get; set; } = null!;
        public virtual Party Registrar { get; set; } = null!;
    }
}
