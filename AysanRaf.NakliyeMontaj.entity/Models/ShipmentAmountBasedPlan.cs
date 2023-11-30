using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ShipmentAmountBasedPlan
    {
        public ShipmentAmountBasedPlan()
        {
            ShipmentAmountBasedPlanItems = new HashSet<ShipmentAmountBasedPlanItem>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DateEndEstimated { get; set; }
        public string? DateStartEstimated { get; set; }
        public string? DeliveryAddressDescription { get; set; }
        public string? DeliveryBuilding { get; set; }
        public string? DeliveryCity { get; set; }
        public string? DeliveryCountryCodeIso3 { get; set; }
        public string? DeliveryDistrictNeighborhoodVillage { get; set; }
        public string? DeliveryFlatIndoorNo { get; set; }
        public string? DeliveryFloor { get; set; }
        public string? DeliveryPostalCode { get; set; }
        public string? DeliverySite { get; set; }
        public string? DeliveryState { get; set; }
        public string? DeliveryStreetBlvAveName { get; set; }
        public string? DeliveryStreetNo { get; set; }
        public string? DeliveryTown { get; set; }
        public string? Description { get; set; }
        public string? FromPartyId { get; set; }
        public string? FromPartyName { get; set; }
        public bool IsDeleted { get; set; }
        public string? PurchaseOrderId { get; set; }
        public string? Sono { get; set; }
        public string? SalesOrderId { get; set; }
        public string? ShipperPartyId { get; set; }
        public string? ShipperPartyName { get; set; }
        public string? StateId { get; set; }
        public string? ToPartyId { get; set; }
        public string? ToPartyName { get; set; }
        public string? TypeId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public decimal Weight { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? FromParty { get; set; }
        public virtual ProcurementPurchaseOrder? PurchaseOrder { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual Party? ShipperParty { get; set; }
        public virtual Party? ToParty { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlanItem> ShipmentAmountBasedPlanItems { get; set; }
    }
}
