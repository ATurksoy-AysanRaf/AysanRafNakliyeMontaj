using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Entites.DTOs
{
    public class RentedEquipmentForDetailDto: BaseDto
    {
        public string Name { get; set; } = null!;
        public decimal DailyCost { get; set; }
        public decimal MonthlyCost { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalCost { get; set; }
    }
}
