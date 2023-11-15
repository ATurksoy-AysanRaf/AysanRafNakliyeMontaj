using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class Pss
    {
        public Pss()
        {
            Assets = new HashSet<Asset>();
            InventoryItems = new HashSet<InventoryItem>();
            InventoryPsstockLevelConstraints = new HashSet<InventoryPsstockLevelConstraint>();
            ProcurementPurchaseOrderItems = new HashSet<ProcurementPurchaseOrderItem>();
            ProcurementRequests = new HashSet<ProcurementRequest>();
            ProcurementRfqbidItems = new HashSet<ProcurementRfqbidItem>();
            PscomponentComponents = new HashSet<Pscomponent>();
            PscomponentPs = new HashSet<Pscomponent>();
            PscomponentTaskTypeExcludes = new HashSet<PscomponentTaskTypeExclude>();
            PsfeatureValues = new HashSet<PsfeatureValue>();
            Psmedia = new HashSet<Psmedia>();
            Psprices = new HashSet<Psprice>();
            SalesCustomerMeetingForms = new HashSet<SalesCustomerMeetingForm>();
            SalesOfferItems = new HashSet<SalesOfferItem>();
            SalesOffers = new HashSet<SalesOffer>();
            SalesOrderItemComponents = new HashSet<SalesOrderItemComponent>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
            SalesOrders = new HashSet<SalesOrder>();
            ShipmentItems = new HashSet<ShipmentItem>();
            TaskPs = new HashSet<Task>();
            TaskPscomponents = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public string? DescriptionShort { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? PscategoryId { get; set; }
        public string? PstypeDiscriminator { get; set; }
        public string? StateId { get; set; }
        public string? Tags { get; set; }
        public string Type { get; set; } = null!;
        public string? UniversalId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? UrlApi { get; set; }
        public string? UrlLargeImage { get; set; }
        public string? UrlMediumImage { get; set; }
        public string? UrlMobile { get; set; }
        public string? UrlSmallImage { get; set; }
        public string? UrlWeb { get; set; }
        public string? Gtin { get; set; }
        public string? ModelCode { get; set; }
        public string? ModelName { get; set; }
        public string? ProductionEndDate { get; set; }
        public string? ReleaseDate { get; set; }
        public string? SupportEndDate { get; set; }
        public string? BrandId { get; set; }
        public string? ManufacturerPscode { get; set; }
        public decimal AmountSecondUnit { get; set; }
        public string? ManufacturerId { get; set; }
        public string? NameEn { get; set; }
        public NpgsqlTsVector? NameEntsVector { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Height { get; set; }
        public decimal? WeightNet { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Party? Manufacturer { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<InventoryPsstockLevelConstraint> InventoryPsstockLevelConstraints { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; }
        public virtual ICollection<ProcurementRfqbidItem> ProcurementRfqbidItems { get; set; }
        public virtual ICollection<Pscomponent> PscomponentComponents { get; set; }
        public virtual ICollection<Pscomponent> PscomponentPs { get; set; }
        public virtual ICollection<PscomponentTaskTypeExclude> PscomponentTaskTypeExcludes { get; set; }
        public virtual ICollection<PsfeatureValue> PsfeatureValues { get; set; }
        public virtual ICollection<Psmedia> Psmedia { get; set; }
        public virtual ICollection<Psprice> Psprices { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingForms { get; set; }
        public virtual ICollection<SalesOfferItem> SalesOfferItems { get; set; }
        public virtual ICollection<SalesOffer> SalesOffers { get; set; }
        public virtual ICollection<SalesOrderItemComponent> SalesOrderItemComponents { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<Task> TaskPs { get; set; }
        public virtual ICollection<Task> TaskPscomponents { get; set; }
    }
}
