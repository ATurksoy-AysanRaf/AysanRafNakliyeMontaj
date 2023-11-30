using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Psprice
    {
        public string Psid { get; set; } = null!;
        public string ChannelId { get; set; } = null!;
        public string SellerId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? CustomerId { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal UnitPrice { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string Id { get; set; } = null!;

        public virtual Party? Customer { get; set; }
        public virtual Pss Ps { get; set; } = null!;
        public virtual Party Seller { get; set; } = null!;
    }
}
