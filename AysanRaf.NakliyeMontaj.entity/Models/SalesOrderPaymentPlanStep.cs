using System;
using System.Collections.Generic;

namespace Models
{
    public partial class SalesOrderPaymentPlanStep
    {
        public string? SalesOrderId { get; set; }
        public int PhaseId { get; set; }
        public int PhasePercent { get; set; }
        public int Days { get; set; }
        public int Method { get; set; }
        public decimal Percent { get; set; }
        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? CustomerName { get; set; }
        public string? DueDate { get; set; }
        public bool IsDone { get; set; }
        public string? Currency { get; set; }
        public string? Note { get; set; }
        public decimal Paid { get; set; }
        public string? Sono { get; set; }
        public string? SalesUserId { get; set; }

        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual AspNetUser? SalesUser { get; set; }
    }
}
