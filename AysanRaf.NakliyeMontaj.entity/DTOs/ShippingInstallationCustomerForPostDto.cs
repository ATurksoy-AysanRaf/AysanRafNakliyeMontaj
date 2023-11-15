using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Entites.DTOs
{
    public class ShippingInstallationCustomerForPostDto:BaseDto
    {
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
