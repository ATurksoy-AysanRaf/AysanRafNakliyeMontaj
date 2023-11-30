using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class AccountingEtatrialBalance
    {
        public string TenantId { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Amount { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CurrencyCodeIso3 { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
    }
}
