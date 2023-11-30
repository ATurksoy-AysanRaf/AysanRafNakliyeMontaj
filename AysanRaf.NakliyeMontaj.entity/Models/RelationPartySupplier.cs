using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class RelationPartySupplier
    {
        public string PartyId { get; set; } = null!;
        public string SupplierId { get; set; } = null!;
        public string? ActualEndDate { get; set; }
        public string? ContractDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? PlannedEndDate { get; set; }
        public string? RelationBreakReason { get; set; }
        public double ScoreDeadlineFit { get; set; }
        public double ScoreDefectRatioFit { get; set; }
        public double ScorePaymentOptionsFit { get; set; }
        public double ScorePriceFit { get; set; }
        public double ScoreQualityFit { get; set; }
        public double ScoreRfqparticipationRate { get; set; }
        public double ScoreRequirementsFit { get; set; }
        public string? StartDate { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public bool IsContracted { get; set; }

        public virtual Party Party { get; set; } = null!;
        public virtual Party Supplier { get; set; } = null!;
    }
}
