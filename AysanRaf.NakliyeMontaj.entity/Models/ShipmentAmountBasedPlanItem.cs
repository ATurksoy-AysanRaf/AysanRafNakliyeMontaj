using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ShipmentAmountBasedPlanItem
    {
        public string ShipmentAmountBasedPlanId { get; set; } = null!;
        public string Psid { get; set; } = null!;
        public decimal AmountInStorage { get; set; }
        public decimal AmountRequired { get; set; }
        public decimal AmountToDo { get; set; }
        public decimal AmountSent { get; set; }
        public decimal AmountToSend { get; set; }
        public string? AmountUnit { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Psn { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public decimal WeightInStorage { get; set; }
        public decimal WeightRequired { get; set; }
        public decimal WeightToDo { get; set; }
        public decimal WeightSent { get; set; }
        public decimal WeightToSend { get; set; }

        public virtual ShipmentAmountBasedPlan ShipmentAmountBasedPlan { get; set; } = null!;
    }
}
