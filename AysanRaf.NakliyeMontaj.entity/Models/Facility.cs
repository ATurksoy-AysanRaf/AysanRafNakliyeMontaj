using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Facility
    {
        public Facility()
        {
            FacilityStorages = new HashSet<FacilityStorage>();
            InventoryItems = new HashSet<InventoryItem>();
            StockCountingActivities = new HashSet<StockCountingActivity>();
        }

        public string Id { get; set; } = null!;
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
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public string? Name { get; set; }
        public string? TenantId { get; set; }
        public string? StateId { get; set; }
        public string? Type { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Party? Tenant { get; set; }
        public virtual ICollection<FacilityStorage> FacilityStorages { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<StockCountingActivity> StockCountingActivities { get; set; }
    }
}
