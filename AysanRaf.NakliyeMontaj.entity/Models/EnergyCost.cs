using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class EnergyCost
    {
        public string TenantId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public decimal ElectricityCostKwh { get; set; }
        public decimal FuelCostLt { get; set; }
        public decimal GasCostM3 { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
    }
}
