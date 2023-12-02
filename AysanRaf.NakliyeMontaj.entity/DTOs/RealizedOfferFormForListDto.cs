using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Entites.DTOs
{
    public class RealizedOfferFormForListDto : BaseDto
    {
        public string Id { get; set; } = null!;
        public string SalesOfferNumber { get; set; } = null!;
        public int RevisionNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? City { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
    }
}
