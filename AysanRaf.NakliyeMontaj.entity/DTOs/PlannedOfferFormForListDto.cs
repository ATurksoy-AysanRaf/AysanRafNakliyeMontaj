using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Entites.DTOs
{
    public class PlannedOfferFormForListDto:BaseDto
    {
        public string SalesOfferNumber { get; set; } = null!;
        public int RevisionNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
    
    }
}
