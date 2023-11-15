using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class SalesOfferPaymentPlanStep
    {
        public string? SalesOfferId { get; set; }
        public int PhaseId { get; set; }
        public int PhasePercent { get; set; }
        public int Days { get; set; }
        public int Method { get; set; }
        public decimal Percent { get; set; }
        public string Id { get; set; } = null!;
        public string? Currency { get; set; }
        public string? Note { get; set; }
        public decimal Amount { get; set; }

        public virtual SalesOffer? SalesOffer { get; set; }
    }
}
