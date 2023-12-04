using System;
using System.Collections.Generic;

namespace Models
{
    public partial class RentedEquipment
    {
        public RentedEquipment()
        {
            Plannedofferforms = new HashSet<PlannedOfferForm>();
            Realizedofferforms = new HashSet<RealizedOfferForm>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal DailyCost { get; set; }
        public decimal MonthlyCost { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalCost { get; set; }

        public virtual ICollection<PlannedOfferForm> Plannedofferforms { get; set; }
        public virtual ICollection<RealizedOfferForm> Realizedofferforms { get; set; }
    }
}
