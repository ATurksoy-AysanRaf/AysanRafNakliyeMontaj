using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Country
    {
        public string Id { get; set; } = null!;
        public double AreaInSqKm { get; set; }
        public string? CapitalName { get; set; }
        public string? CodeIso2 { get; set; }
        public string? CodeIso3 { get; set; }
        public string? CodeIsoNumeric { get; set; }
        public string? ContinentCode2 { get; set; }
        public string? ContinentName { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CurrencyCode3 { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencySymbolUnicode { get; set; }
        public double East { get; set; }
        public string? FipsCode { get; set; }
        public string? GeonameId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public double North { get; set; }
        public string? OfficialName { get; set; }
        public string? PhoneCode { get; set; }
        public double South { get; set; }
        public string? StateId { get; set; }
        public string? SubCurrencyName { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public double West { get; set; }
    }
}
