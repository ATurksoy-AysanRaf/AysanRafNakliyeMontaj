using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOfferItem
    {
        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CurrencyDefault { get; set; }
        public string? CustomerId { get; set; }
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public string? PscategoryId { get; set; }
        public string? Psid { get; set; }
        public string? SalesOfferId { get; set; }
        public string? StateId { get; set; }
        public decimal TaxPercent { get; set; }
        public string? TenantId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? ExchangeDate { get; set; }
        public decimal UnitPriceDefault { get; set; }
        public string? ProjectName { get; set; }

        public virtual Party? Customer { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual SalesOffer? SalesOffer { get; set; }
    }
}
