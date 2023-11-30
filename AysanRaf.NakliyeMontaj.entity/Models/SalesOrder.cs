using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            InventoryItems = new HashSet<InventoryItem>();
            ProcurementRequests = new HashSet<ProcurementRequest>();
            Projects = new HashSet<Project>();
            SalesOrderCustomerFiles = new HashSet<SalesOrderCustomerFile>();
            SalesOrderInternalFiles = new HashSet<SalesOrderInternalFile>();
            SalesOrderInvoices = new HashSet<SalesOrderInvoice>();
            SalesOrderItemComponents = new HashSet<SalesOrderItemComponent>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
            SalesOrderNotes = new HashSet<SalesOrderNote>();
            SalesOrderPaymentPlanSteps = new HashSet<SalesOrderPaymentPlanStep>();
            ShipmentAmountBasedPlans = new HashSet<ShipmentAmountBasedPlan>();
            ShipmentItems = new HashSet<ShipmentItem>();
            Shipments = new HashSet<Shipment>();
            Tasks = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public string? AccessCode { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? CustomerContactPersonId { get; set; }
        public string? CustomerId { get; set; }
        public string? DateEndDeliveryEstimated { get; set; }
        public string? DateEndInstallationEstimated { get; set; }
        public string? DateEndProductionEstimated { get; set; }
        public string? DateEndUnInstallationEstimated { get; set; }
        public string? DateStartDeliveryEstimated { get; set; }
        public string? DateStartInstallationEstimated { get; set; }
        public string? DateStartProductionEstimated { get; set; }
        public string? DateStartUnInstallationEstimated { get; set; }
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
        public string? DescriptionColor { get; set; }
        public string? DescriptionDeliveryAddress { get; set; }
        public string? DescriptionDeliveryDate { get; set; }
        public string? DescriptionPayment { get; set; }
        public string? DescriptionSalesTerms { get; set; }
        public string? DescriptionTax { get; set; }
        public string? DescriptionWarranty { get; set; }
        public string? DocumentSalesContractCustomerSignedFileName { get; set; }
        public string? DocumentSalesContractTenantSignedFileName { get; set; }
        public string? DocumentSalesOfferCustomerSignedFileName { get; set; }
        public string? DocumentSalesOfferTenantSignedFileName { get; set; }
        public string? InvoiceBuilding { get; set; }
        public string? InvoiceCity { get; set; }
        public string? InvoiceCountryCodeIso3 { get; set; }
        public string? InvoiceDistrictNeighborhoodVillage { get; set; }
        public string? InvoiceFlatIndoorNo { get; set; }
        public string? InvoiceFloor { get; set; }
        public string? InvoicePostalCode { get; set; }
        public string? InvoiceSite { get; set; }
        public string? InvoiceState { get; set; }
        public string? InvoiceStreetBlvAveName { get; set; }
        public string? InvoiceStreetNo { get; set; }
        public string? InvoiceTown { get; set; }
        public bool IsDeleted { get; set; }
        public string? PscategoryId { get; set; }
        public string? Psid { get; set; }
        public int PalletCount { get; set; }
        public string? PaymentPlanType { get; set; }
        public decimal PriceDiscount { get; set; }
        public decimal PriceDiscountRate { get; set; }
        public string? PriceDiscountType { get; set; }
        public decimal PriceInstallation { get; set; }
        public decimal PriceProductServiceTotal { get; set; }
        public decimal PriceShipment { get; set; }
        public decimal PriceTotal { get; set; }
        public decimal PriceTotalWithoutShipmentInstallation { get; set; }
        public decimal PriceUnInstallation { get; set; }
        public string? ProductionDirectorUserId { get; set; }
        public int ProductionDirectorWorkMinutes { get; set; }
        public string? ProductionManagerUserId { get; set; }
        public int ProductionManagerWorkMinutes { get; set; }
        public string? ProductionPlannerUserId { get; set; }
        public int ProductionPlannerWorkMinutes { get; set; }
        public string? ProjectDesignerUserId { get; set; }
        public int ProjectDesignerWorkMinutes { get; set; }
        public string? ProjectManagerUserId { get; set; }
        public int ProjectManagerWorkMinutes { get; set; }
        public string? ResellerContactPersonId { get; set; }
        public string? ResellerId { get; set; }
        public string? SalesManagerUserId { get; set; }
        public int SalesManagerWorkMinutes { get; set; }
        public string? SalesOfferId { get; set; }
        public string? SalesOrderNumber { get; set; }
        public string? SalesOrderNumberPrevious { get; set; }
        public string? SalesPersonUserId { get; set; }
        public int SalesPersonWorkMinutes { get; set; }
        public bool ShowSecondUnitPricingToCustomer { get; set; }
        public string? StateId { get; set; }
        public decimal TaxPercent { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public int ValidityDeadlineDays { get; set; }
        public string? ExchangeDate { get; set; }
        public string? CustomerContactPersonName { get; set; }
        public string? CustomerPurchaseOrderId { get; set; }
        public string? Title { get; set; }
        public string? DescriptionInstallation { get; set; }
        public string? DescriptionStandarts { get; set; }
        public string? DescriptionWeight { get; set; }
        public string? ThanksToCustomer { get; set; }
        public string? CurrencyServices { get; set; }
        public decimal Eurtryparity { get; set; }
        public decimal Eurusdparity { get; set; }
        public string? FixedParityTypeId { get; set; }
        public decimal Gbptryparity { get; set; }
        public decimal Gbpusdparity { get; set; }
        public bool HasInstallation { get; set; }
        public bool HasShipment { get; set; }
        public bool HasStaticCalculation { get; set; }
        public bool HasUnInstallation { get; set; }
        public decimal PriceStaticCalculation { get; set; }
        public int RevisionNumber { get; set; }
        public int RevisionNumberNew { get; set; }
        public string? RootSalesOrderId { get; set; }
        public decimal TaxWitholding { get; set; }
        public decimal Usdtryparity { get; set; }
        public string? CancellationDate { get; set; }
        public string? CancellationDescription { get; set; }
        public string? CancellationTypeId { get; set; }
        public string? CompletedDate { get; set; }
        public string? SalesOfferNumber { get; set; }
        public int SalesOfferRevisionNumber { get; set; }
        public string? DocumentCompletionCustomerApprovalFileName { get; set; }
        public string? PlannedDate { get; set; }
        public int TaskCreationType { get; set; }
        public string? CustomerContactPersonEmail { get; set; }
        public string? CustomerContactPersonFullName { get; set; }
        public string? CustomerContactPersonPhone { get; set; }
        public string? CustomerName { get; set; }
        public string? ResellerContactPersonFullName { get; set; }
        public string? ResellerName { get; set; }
        public string? DocumentInvoiceFileName { get; set; }
        public string? InvoiceDate { get; set; }
        public string? InvoiceNo { get; set; }
        public int SeqNo { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? Customer { get; set; }
        public virtual Party? CustomerContactPerson { get; set; }
        public virtual AspNetUser? ProductionDirectorUser { get; set; }
        public virtual AspNetUser? ProductionManagerUser { get; set; }
        public virtual AspNetUser? ProductionPlannerUser { get; set; }
        public virtual AspNetUser? ProjectDesignerUser { get; set; }
        public virtual AspNetUser? ProjectManagerUser { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual Party? Reseller { get; set; }
        public virtual Party? ResellerContactPerson { get; set; }
        public virtual AspNetUser? SalesManagerUser { get; set; }
        public virtual SalesOffer? SalesOffer { get; set; }
        public virtual AspNetUser? SalesPersonUser { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SalesOrderCustomerFile> SalesOrderCustomerFiles { get; set; }
        public virtual ICollection<SalesOrderInternalFile> SalesOrderInternalFiles { get; set; }
        public virtual ICollection<SalesOrderInvoice> SalesOrderInvoices { get; set; }
        public virtual ICollection<SalesOrderItemComponent> SalesOrderItemComponents { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual ICollection<SalesOrderNote> SalesOrderNotes { get; set; }
        public virtual ICollection<SalesOrderPaymentPlanStep> SalesOrderPaymentPlanSteps { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlans { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
