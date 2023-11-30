using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class AccountingEtacurrentBalance
    {
        public string Id { get; set; } = null!;
        public decimal BalanceForeignCurrency { get; set; }
        public string? CollectionDescription { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CurrencyCodeIso3 { get; set; }
        public decimal DepthAmountForeignCurrency { get; set; }
        public decimal DepthAmountTry { get; set; }
        public decimal Difference { get; set; }
        public string? DueDateAverage { get; set; }
        public bool IsDeleted { get; set; }
        public string? PartyId { get; set; }
        public string? PartyName { get; set; }
        public decimal ReceivableAmountForeignCurrency { get; set; }
        public decimal ReceivableAmountTry { get; set; }
        public string? SalesPersonCode { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
    }
}
