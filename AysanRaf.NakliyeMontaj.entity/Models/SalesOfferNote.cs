using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOfferNote
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserEmail { get; set; }
        public string? CreatedUserFullName { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Note { get; set; }
        public string? SalesOfferId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual SalesOffer? SalesOffer { get; set; }
    }
}
