using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class Contact
    {
        public string Id { get; set; } = null!;
        public string? AccessUrl { get; set; }
        public string? AddressBuilding { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressCountryCodeIso3 { get; set; }
        public string? AddressDistrictNeighborhoodVillage { get; set; }
        public string? AddressFlatIndoorNo { get; set; }
        public string? AddressFloor { get; set; }
        public string? AddressPostalCode { get; set; }
        public string? AddressSite { get; set; }
        public string? AddressState { get; set; }
        public string? AddressStreetBlvAveName { get; set; }
        public string? AddressStreetNo { get; set; }
        public string? AddressTown { get; set; }
        public string? ContactPersonId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DateEnd { get; set; }
        public string? DateStart { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public bool IsDeleted { get; set; }
        public string? LandPhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? PartyId { get; set; }
        public string? StateId { get; set; }
        public string? Type { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? WebSiteUrl { get; set; }

        public virtual Party? ContactPerson { get; set; }
        public virtual Party? Party { get; set; }
    }
}
