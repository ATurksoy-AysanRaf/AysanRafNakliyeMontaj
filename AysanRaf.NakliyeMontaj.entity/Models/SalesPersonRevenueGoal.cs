using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesPersonRevenueGoal
    {
        public string TenantId { get; set; } = null!;
        public string SalesPersonUserId { get; set; } = null!;
        public int Year { get; set; }
        public decimal Achieved { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public decimal Goal { get; set; }
        public bool IsDeleted { get; set; }
        public string? Note { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser SalesPersonUser { get; set; } = null!;
    }
}
