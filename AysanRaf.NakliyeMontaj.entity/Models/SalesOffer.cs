using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOffer
    {
        public SalesOffer()
        {
            SalesOfferCustomerFiles = new HashSet<SalesOfferCustomerFile>();
            SalesOfferInternalFiles = new HashSet<SalesOfferInternalFile>();
            SalesOfferItems = new HashSet<SalesOfferItem>();
            SalesOfferNotes = new HashSet<SalesOfferNote>();
            SalesOfferPaymentPlanSteps = new HashSet<SalesOfferPaymentPlanStep>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        public string Id { get; set; } = null!;
        public string? AccessCode { get; set; }
        public string? DeliveryBuilding { get; set; }
        public string? DeliveryCity { get; set; }
        public string? DeliveryCountryCodeIso3 { get; set; }
        public string? DeliveryDistrictNeighborhoodVillage { get; set; }
        public string? DeliveryFloor { get; set; }
        public string? DeliveryPostalCode { get; set; }
        public string? DeliveryStreetNo { get; set; }
        public string? DeliverySite { get; set; }
        public string? DeliveryState { get; set; }
        public string? DeliveryStreetBlvAveName { get; set; }
        public string? SalesOfferNumberPrevious { get; set; }
        public string? DeliveryTown { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? CustomerContactPersonId { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerResponse { get; set; }
        public string? CustomerResponseTypeId { get; set; }
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
        public bool IsDeleted { get; set; }
        public int PalletCount { get; set; }
        public string? PaymentPlanType { get; set; }
        public decimal PriceDiscount { get; set; }
        public decimal PriceDiscountRate { get; set; }
        public decimal PriceInstallation { get; set; }
        public decimal PriceProductServiceTotal { get; set; }
        public decimal PriceShipment { get; set; }
        public decimal PriceTotal { get; set; }
        public decimal PriceTotalWithoutShipmentInstallation { get; set; }
        public decimal PriceUnInstallation { get; set; }
        public string? ProformaInvoiceId { get; set; }
        public string? ProjectDesignerUserId { get; set; }
        public int ProjectDesignerWorkMinutes { get; set; }
        public string? ProjectManagerUserId { get; set; }
        public int ProjectManagerWorkMinutes { get; set; }
        public string? ResellerContactPersonId { get; set; }
        public string? ResellerId { get; set; }
        public int RevisionNumber { get; set; }
        public string? RootSalesOfferId { get; set; }
        public string? SalesCustomerMeetingFormId { get; set; }
        public string? SalesManagerUserId { get; set; }
        public int SalesManagerWorkMinutes { get; set; }
        public string? SalesOfferNumber { get; set; }
        public string? SalesPersonUserId { get; set; }
        public int SalesPersonWorkMinutes { get; set; }
        public bool ShowSecondUnitPricingToCustomer { get; set; }
        public string? StateId { get; set; }
        public decimal TaxPercent { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public int ValidityDeadlineDays { get; set; }
        public string? PscategoryId { get; set; }
        public string? Psid { get; set; }
        public string? PriceDiscountType { get; set; }
        public string? DeliveryFlatIndoorNo { get; set; }
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
        public string? ExchangeDate { get; set; }
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
        public string? ProjectNames { get; set; }
        public decimal TaxWitholding { get; set; }
        public decimal Usdtryparity { get; set; }
        public string? CustomerContactPersonEmail { get; set; }
        public string? CustomerContactPersonFullName { get; set; }
        public string? CustomerContactPersonPhone { get; set; }
        public string? CustomerName { get; set; }
        public string? ResellerContactPersonFullName { get; set; }
        public string? ResellerName { get; set; }
        public string? CancellationDate { get; set; }
        public string? CancellationDescription { get; set; }
        public string? CancellationTypeId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? Customer { get; set; }
        public virtual Party? CustomerContactPerson { get; set; }
        public virtual AspNetUser? ProjectDesignerUser { get; set; }
        public virtual AspNetUser? ProjectManagerUser { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual Party? Reseller { get; set; }
        public virtual Party? ResellerContactPerson { get; set; }
        public virtual SalesCustomerMeetingForm? SalesCustomerMeetingForm { get; set; }
        public virtual AspNetUser? SalesManagerUser { get; set; }
        public virtual AspNetUser? SalesPersonUser { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<SalesOfferCustomerFile> SalesOfferCustomerFiles { get; set; }
        public virtual ICollection<SalesOfferInternalFile> SalesOfferInternalFiles { get; set; }
        public virtual ICollection<SalesOfferItem> SalesOfferItems { get; set; }
        public virtual ICollection<SalesOfferNote> SalesOfferNotes { get; set; }
        public virtual ICollection<SalesOfferPaymentPlanStep> SalesOfferPaymentPlanSteps { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
