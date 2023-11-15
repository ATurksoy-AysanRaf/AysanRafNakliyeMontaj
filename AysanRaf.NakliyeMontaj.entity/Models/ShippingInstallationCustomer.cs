using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class ShippingInstallationCustomer
    {
       
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
