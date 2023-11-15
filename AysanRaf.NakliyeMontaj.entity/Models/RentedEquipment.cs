using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class RentedEquipment
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal DailyCost { get; set; }
        public decimal MonthlyCost { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalCost { get; set; }
    }
}
