using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Pscategory
    {
        public Pscategory()
        {
            InventoryItems = new HashSet<InventoryItem>();
            ProcurementPurchaseOrderItems = new HashSet<ProcurementPurchaseOrderItem>();
            ProcurementRequests = new HashSet<ProcurementRequest>();
            ProcurementRfqbidItems = new HashSet<ProcurementRfqbidItem>();
            PscategoryMedia = new HashSet<PscategoryMedia>();
            Psfeatures = new HashSet<Psfeature>();
            Psses = new HashSet<Pss>();
            RelationSupplierPscategories = new HashSet<RelationSupplierPscategory>();
            SalesCustomerMeetingForms = new HashSet<SalesCustomerMeetingForm>();
            SalesOfferItems = new HashSet<SalesOfferItem>();
            SalesOffers = new HashSet<SalesOffer>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; } = null!;
        public string? PstypeDiscriminator { get; set; }
        public string? PurchaseUnit { get; set; }
        public string? StateId { get; set; }
        public string? UniversalId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? PurchaseUnitSecondary { get; set; }
        public decimal UnitCc { get; set; }
        public string? IntegrationCode { get; set; }

        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; }
        public virtual ICollection<ProcurementRfqbidItem> ProcurementRfqbidItems { get; set; }
        public virtual ICollection<PscategoryMedia> PscategoryMedia { get; set; }
        public virtual ICollection<Psfeature> Psfeatures { get; set; }
        public virtual ICollection<Pss> Psses { get; set; }
        public virtual ICollection<RelationSupplierPscategory> RelationSupplierPscategories { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingForms { get; set; }
        public virtual ICollection<SalesOfferItem> SalesOfferItems { get; set; }
        public virtual ICollection<SalesOffer> SalesOffers { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
