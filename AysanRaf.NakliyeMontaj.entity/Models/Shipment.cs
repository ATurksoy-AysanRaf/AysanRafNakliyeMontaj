using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            ExpenseRecords = new HashSet<ExpenseRecord>();
            ShipmentItems = new HashSet<ShipmentItem>();
            ShipmentWayBillDocuments = new HashSet<ShipmentWayBillDocument>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DateEndActual { get; set; }
        public string? DateEndEstimated { get; set; }
        public string? DateStartActual { get; set; }
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
        public string? DescriptionHandling { get; set; }
        public string? DocumentExportImportFileName { get; set; }
        public string? DocumentExporterImporterInvoiceFileName { get; set; }
        public string? DocumentShipperInvoiceFileName { get; set; }
        public string? DocumentWayBillFileName { get; set; }
        public decimal ExporterImporterCostActual { get; set; }
        public string? ExporterImporterPartyId { get; set; }
        public decimal ExporterImporterTaxPercent { get; set; }
        public string? FromPartyId { get; set; }
        public bool IsDeleted { get; set; }
        public string? ProformaInvoiceId { get; set; }
        public string? PurchaseOrderId { get; set; }
        public string? SalesOrderId { get; set; }
        public string? ShipmentManagerUserId { get; set; }
        public int ShipmentManagerWorkMinutes { get; set; }
        public string? ShipmentPersonUserId { get; set; }
        public int ShipmentPersonWorkMinutes { get; set; }
        public string? ShipmentPlannerUserId { get; set; }
        public int ShipmentPlannerWorkMinutes { get; set; }
        public decimal ShipperCostActual { get; set; }
        public string? ShipperPartyId { get; set; }
        public decimal ShipperTaxPercent { get; set; }
        public string? StateId { get; set; }
        public string? ToPartyId { get; set; }
        public string? TypeId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? WayBillNo { get; set; }
        public string? ShipperCostCurrency { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? FromPartyName { get; set; }
        public string? ToPartyName { get; set; }
        public string? ShipperPartyName { get; set; }
        public string? ShipperInvoiceDate { get; set; }
        public string? ShipperInvoiceNo { get; set; }
        public string? VehiclePlateNo { get; set; }
        public decimal Weight { get; set; }
        public string? DriverFirstName { get; set; }
        public string? DriverLastName { get; set; }
        public string? DriverPersonId { get; set; }
        public string? DriverCitizenId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? DriverPerson { get; set; }
        public virtual Party? ExporterImporterParty { get; set; }
        public virtual Party? FromParty { get; set; }
        public virtual ProcurementPurchaseOrder? PurchaseOrder { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual AspNetUser? ShipmentManagerUser { get; set; }
        public virtual AspNetUser? ShipmentPersonUser { get; set; }
        public virtual AspNetUser? ShipmentPlannerUser { get; set; }
        public virtual Party? ShipperParty { get; set; }
        public virtual Party? ToParty { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<ShipmentWayBillDocument> ShipmentWayBillDocuments { get; set; }
    }
}
