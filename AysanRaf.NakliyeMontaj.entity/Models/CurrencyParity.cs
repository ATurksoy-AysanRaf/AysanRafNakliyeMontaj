﻿using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class CurrencyParity
    {
        public string Date { get; set; } = null!;
        public string Parity { get; set; } = null!;
        public decimal Ratio { get; set; }
    }
}