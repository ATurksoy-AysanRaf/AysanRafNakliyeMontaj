using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class SalesCustomerMeetingForm
    {
        public SalesCustomerMeetingForm()
        {
            SalesCustomerMeetingFormFiles = new HashSet<SalesCustomerMeetingFormFile>();
            SalesOffers = new HashSet<SalesOffer>();
        }

        public string Id { get; set; } = null!;
        public string? AboveSafetyProfile { get; set; }
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
        public string? BarriersToRackingSystem { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CustomerContactPersonId { get; set; }
        public string? CustomerId { get; set; }
        public string? DepotArchitectureProjectType { get; set; }
        public string? DepotFeature { get; set; }
        public string? DescriptionInstallationPlace { get; set; }
        public string? EyeCapacity { get; set; }
        public string? FloorCondition { get; set; }
        public string? FloorRailType { get; set; }
        public string? FootProtectionType { get; set; }
        public string? ForkliftLiftingHeight { get; set; }
        public string? ForkliftTurnRadius { get; set; }
        public string? ForkliftTypeAndName { get; set; }
        public string? InvestmentType { get; set; }
        public bool IsDeleted { get; set; }
        public string? MeetingDate { get; set; }
        public string? NoteRevisionRequest { get; set; }
        public string? PscategoryId { get; set; }
        public string? Psid { get; set; }
        public string? PalletDimensions { get; set; }
        public string? PalletHeight { get; set; }
        public string? PalletLeaningProfile { get; set; }
        public string? PalletTasintilari { get; set; }
        public string? PalletWeight { get; set; }
        public string? ProjectDate { get; set; }
        public string? ProjectManagerUserId { get; set; }
        public string? RailTypeToInstall { get; set; }
        public string? ResellerContactPersonId { get; set; }
        public string? ResellerId { get; set; }
        public string? RoofMaxHeight { get; set; }
        public string? SalesManagerUserId { get; set; }
        public string? SalesPersonUserId { get; set; }
        public string? StateId { get; set; }
        public string? StaticCalculationType { get; set; }
        public string? SurfaceCoverType { get; set; }
        public string? SurfaceType { get; set; }
        public string? SystemType { get; set; }
        public string? TenantId { get; set; }
        public string? ThirdTraverseHtype { get; set; }
        public string? UnderPalletSafetyProfile { get; set; }
        public string? UnderWoodSafetyPallet { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ContactChannelType { get; set; }
        public string? ContactSubjectType { get; set; }
        public string? CustomerContactPersonEmail { get; set; }
        public string? CustomerContactPersonFullName { get; set; }
        public string? CustomerContactPersonPhone { get; set; }
        public string? CustomerName { get; set; }
        public string? ResellerContactPersonFullName { get; set; }
        public string? ResellerName { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? Customer { get; set; }
        public virtual Party? CustomerContactPerson { get; set; }
        public virtual AspNetUser? ProjectManagerUser { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual Party? Reseller { get; set; }
        public virtual Party? ResellerContactPerson { get; set; }
        public virtual AspNetUser? SalesManagerUser { get; set; }
        public virtual AspNetUser? SalesPersonUser { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<SalesCustomerMeetingFormFile> SalesCustomerMeetingFormFiles { get; set; }
        public virtual ICollection<SalesOffer> SalesOffers { get; set; }
    }
}
