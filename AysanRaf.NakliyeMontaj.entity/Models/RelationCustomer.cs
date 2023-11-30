using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class RelationCustomer
    {
        public string PartyId { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string? ActualEndDate { get; set; }
        public string? ContractDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsContracted { get; set; }
        public bool IsDeleted { get; set; }
        public string? PlannedEndDate { get; set; }
        public string? RelationBreakReason { get; set; }
        public double ScorePaymentFit { get; set; }
        public string? StartDate { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? AcquisitionChannelId { get; set; }
        public string? AcquisitionChannelName { get; set; }
        public string? AcquisitionChannelType { get; set; }
        public string? ReferenceId { get; set; }
        public string? CurrencyContract { get; set; }
        public string? CurrencyOffer { get; set; }

        public virtual Party Customer { get; set; } = null!;
        public virtual Party Party { get; set; } = null!;
        public virtual Party? Reference { get; set; }
    }
}
