using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Party
    {
        public Party()
        {
            Brands = new HashSet<Brand>();
            ContactContactPeople = new HashSet<Contact>();
            ContactParties = new HashSet<Contact>();
            Departments = new HashSet<Department>();
            Employments = new HashSet<Employment>();
            ExpenseRecords = new HashSet<ExpenseRecord>();
            Facilities = new HashSet<Facility>();
            FacilityStorages = new HashSet<FacilityStorage>();
            InventoryItemSuppliers = new HashSet<InventoryItem>();
            InventoryItemTenants = new HashSet<InventoryItem>();
            InventoryItemTransactions = new HashSet<InventoryItemTransaction>();
            InverseRegistrarIndustry = new HashSet<Party>();
            InverseRegistrarTax = new HashSet<Party>();
            InverseRegistrarTradeCommerce = new HashSet<Party>();
            ProcurementPurchaseOrderItems = new HashSet<ProcurementPurchaseOrderItem>();
            ProcurementPurchaseOrderSuppliers = new HashSet<ProcurementPurchaseOrder>();
            ProcurementPurchaseOrderTenants = new HashSet<ProcurementPurchaseOrder>();
            ProcurementRequests = new HashSet<ProcurementRequest>();
            ProcurementRfqbidItems = new HashSet<ProcurementRfqbidItem>();
            ProcurementRfqbidSuppliers = new HashSet<ProcurementRfqbid>();
            ProcurementRfqbidTenants = new HashSet<ProcurementRfqbid>();
            ProcurementUserNotificationSettings = new HashSet<ProcurementUserNotificationSetting>();
            Projects = new HashSet<Project>();
            Pscomponents = new HashSet<Pscomponent>();
            PspriceCustomers = new HashSet<Psprice>();
            PspriceSellers = new HashSet<Psprice>();
            Psses = new HashSet<Pss>();
            RelationCustomerContactPersonContacts = new HashSet<RelationCustomerContactPerson>();
            RelationCustomerContactPersonCustomers = new HashSet<RelationCustomerContactPerson>();
            RelationCustomerContactPersonTenants = new HashSet<RelationCustomerContactPerson>();
            RelationCustomerCustomers = new HashSet<RelationCustomer>();
            RelationCustomerParties = new HashSet<RelationCustomer>();
            RelationCustomerReferences = new HashSet<RelationCustomer>();
            RelationPartyQascertificateAccreditors = new HashSet<RelationPartyQascertificate>();
            RelationPartyQascertificateParties = new HashSet<RelationPartyQascertificate>();
            RelationPartyQascertificateRegistrars = new HashSet<RelationPartyQascertificate>();
            RelationPartyRegistryParties = new HashSet<RelationPartyRegistry>();
            RelationPartyRegistryRegistrars = new HashSet<RelationPartyRegistry>();
            RelationPartySupplierParties = new HashSet<RelationPartySupplier>();
            RelationPartySupplierSuppliers = new HashSet<RelationPartySupplier>();
            RelationResellerContactPersonContacts = new HashSet<RelationResellerContactPerson>();
            RelationResellerContactPersonResellers = new HashSet<RelationResellerContactPerson>();
            RelationResellerContactPersonTenants = new HashSet<RelationResellerContactPerson>();
            RelationResellerParties = new HashSet<RelationReseller>();
            RelationResellerResellers = new HashSet<RelationReseller>();
            RelationSupplierPscategories = new HashSet<RelationSupplierPscategory>();
            RelationSupplierSalesPersonEmployees = new HashSet<RelationSupplierSalesPerson>();
            RelationSupplierSalesPersonSuppliers = new HashSet<RelationSupplierSalesPerson>();
            RelationSupplierSalesPersonTenants = new HashSet<RelationSupplierSalesPerson>();
            SalesCustomerMeetingFormCustomerContactPeople = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormCustomers = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormResellerContactPeople = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormResellers = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormTenants = new HashSet<SalesCustomerMeetingForm>();
            SalesOfferCustomerContactPeople = new HashSet<SalesOffer>();
            SalesOfferCustomers = new HashSet<SalesOffer>();
            SalesOfferItems = new HashSet<SalesOfferItem>();
            SalesOfferResellerContactPeople = new HashSet<SalesOffer>();
            SalesOfferResellers = new HashSet<SalesOffer>();
            SalesOfferTenants = new HashSet<SalesOffer>();
            SalesOrderCustomerContactPeople = new HashSet<SalesOrder>();
            SalesOrderCustomers = new HashSet<SalesOrder>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
            SalesOrderResellerContactPeople = new HashSet<SalesOrder>();
            SalesOrderResellers = new HashSet<SalesOrder>();
            SalesOrderTenants = new HashSet<SalesOrder>();
            ShipmentAmountBasedPlanFromParties = new HashSet<ShipmentAmountBasedPlan>();
            ShipmentAmountBasedPlanShipperParties = new HashSet<ShipmentAmountBasedPlan>();
            ShipmentAmountBasedPlanToParties = new HashSet<ShipmentAmountBasedPlan>();
            ShipmentDriverPeople = new HashSet<Shipment>();
            ShipmentExporterImporterParties = new HashSet<Shipment>();
            ShipmentFromParties = new HashSet<Shipment>();
            ShipmentItemFromParties = new HashSet<ShipmentItem>();
            ShipmentItemToParties = new HashSet<ShipmentItem>();
            ShipmentShipperParties = new HashSet<Shipment>();
            ShipmentToParties = new HashSet<Shipment>();
        }

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
        public string? CitizenId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DateEnd { get; set; }
        public string? DateStart { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public short Gender { get; set; }
        public string? ImageAvatarLogoBase64 { get; set; }
        public string? ImageBase64 { get; set; }
        public bool IsDeleted { get; set; }
        public string? LandPhone { get; set; }
        public string? LastName { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public string? MarriageFamilyName { get; set; }
        public string? MidName { get; set; }
        public string? MobilePhone { get; set; }
        public string Name { get; set; } = null!;
        public string? OrganizationSubTypeId { get; set; }
        public string? OrganizationTypeId { get; set; }
        public string? PrimaryLanguageCodeIso3 { get; set; }
        public string? StateId { get; set; }
        public string Type { get; set; } = null!;
        public string? UniversalId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? UserId { get; set; }
        public string? WebSiteUrl { get; set; }
        public string? BusinessCentralIdCode { get; set; }
        public string? BusinessIdCode { get; set; }
        public string? EmployerIdCode { get; set; }
        public string? RegistrarIndustryId { get; set; }
        public string? RegistrarTaxId { get; set; }
        public string? RegistrarTradeCommerceId { get; set; }
        public string? RegistrationIndustryId { get; set; }
        public string? RegistrationTaxId { get; set; }
        public string? RegistrationTradeCommerceId { get; set; }
        public string? RegistrarTaxCode { get; set; }
        public string? IntegrationCode { get; set; }
        public string? Title { get; set; }
        public string? BformContactEmail { get; set; }
        public string? BformContactPhone { get; set; }
        public string? CurrentAccountEmail { get; set; }
        public string? CurrentAccountPhone { get; set; }
        public string? EinvoiceContactEmail { get; set; }
        public string? EinvoiceContactPhone { get; set; }

        public virtual Party? RegistrarIndustry { get; set; }
        public virtual Party? RegistrarTax { get; set; }
        public virtual Party? RegistrarTradeCommerce { get; set; }
        public virtual AspNetUser? User { get; set; }
        public virtual OrganizationDetail OrganizationDetail { get; set; } = null!;
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<Contact> ContactContactPeople { get; set; }
        public virtual ICollection<Contact> ContactParties { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Employment> Employments { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<FacilityStorage> FacilityStorages { get; set; }
        public virtual ICollection<InventoryItem> InventoryItemSuppliers { get; set; }
        public virtual ICollection<InventoryItem> InventoryItemTenants { get; set; }
        public virtual ICollection<InventoryItemTransaction> InventoryItemTransactions { get; set; }
        public virtual ICollection<Party> InverseRegistrarIndustry { get; set; }
        public virtual ICollection<Party> InverseRegistrarTax { get; set; }
        public virtual ICollection<Party> InverseRegistrarTradeCommerce { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; }
        public virtual ICollection<ProcurementPurchaseOrder> ProcurementPurchaseOrderSuppliers { get; set; }
        public virtual ICollection<ProcurementPurchaseOrder> ProcurementPurchaseOrderTenants { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; }
        public virtual ICollection<ProcurementRfqbidItem> ProcurementRfqbidItems { get; set; }
        public virtual ICollection<ProcurementRfqbid> ProcurementRfqbidSuppliers { get; set; }
        public virtual ICollection<ProcurementRfqbid> ProcurementRfqbidTenants { get; set; }
        public virtual ICollection<ProcurementUserNotificationSetting> ProcurementUserNotificationSettings { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Pscomponent> Pscomponents { get; set; }
        public virtual ICollection<Psprice> PspriceCustomers { get; set; }
        public virtual ICollection<Psprice> PspriceSellers { get; set; }
        public virtual ICollection<Pss> Psses { get; set; }
        public virtual ICollection<RelationCustomerContactPerson> RelationCustomerContactPersonContacts { get; set; }
        public virtual ICollection<RelationCustomerContactPerson> RelationCustomerContactPersonCustomers { get; set; }
        public virtual ICollection<RelationCustomerContactPerson> RelationCustomerContactPersonTenants { get; set; }
        public virtual ICollection<RelationCustomer> RelationCustomerCustomers { get; set; }
        public virtual ICollection<RelationCustomer> RelationCustomerParties { get; set; }
        public virtual ICollection<RelationCustomer> RelationCustomerReferences { get; set; }
        public virtual ICollection<RelationPartyQascertificate> RelationPartyQascertificateAccreditors { get; set; }
        public virtual ICollection<RelationPartyQascertificate> RelationPartyQascertificateParties { get; set; }
        public virtual ICollection<RelationPartyQascertificate> RelationPartyQascertificateRegistrars { get; set; }
        public virtual ICollection<RelationPartyRegistry> RelationPartyRegistryParties { get; set; }
        public virtual ICollection<RelationPartyRegistry> RelationPartyRegistryRegistrars { get; set; }
        public virtual ICollection<RelationPartySupplier> RelationPartySupplierParties { get; set; }
        public virtual ICollection<RelationPartySupplier> RelationPartySupplierSuppliers { get; set; }
        public virtual ICollection<RelationResellerContactPerson> RelationResellerContactPersonContacts { get; set; }
        public virtual ICollection<RelationResellerContactPerson> RelationResellerContactPersonResellers { get; set; }
        public virtual ICollection<RelationResellerContactPerson> RelationResellerContactPersonTenants { get; set; }
        public virtual ICollection<RelationReseller> RelationResellerParties { get; set; }
        public virtual ICollection<RelationReseller> RelationResellerResellers { get; set; }
        public virtual ICollection<RelationSupplierPscategory> RelationSupplierPscategories { get; set; }
        public virtual ICollection<RelationSupplierSalesPerson> RelationSupplierSalesPersonEmployees { get; set; }
        public virtual ICollection<RelationSupplierSalesPerson> RelationSupplierSalesPersonSuppliers { get; set; }
        public virtual ICollection<RelationSupplierSalesPerson> RelationSupplierSalesPersonTenants { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormCustomerContactPeople { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormCustomers { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormResellerContactPeople { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormResellers { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormTenants { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferCustomerContactPeople { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferCustomers { get; set; }
        public virtual ICollection<SalesOfferItem> SalesOfferItems { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferResellerContactPeople { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferResellers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferTenants { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderCustomerContactPeople { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderCustomers { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderResellerContactPeople { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderResellers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderTenants { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlanFromParties { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlanShipperParties { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlanToParties { get; set; }
        public virtual ICollection<Shipment> ShipmentDriverPeople { get; set; }
        public virtual ICollection<Shipment> ShipmentExporterImporterParties { get; set; }
        public virtual ICollection<Shipment> ShipmentFromParties { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItemFromParties { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItemToParties { get; set; }
        public virtual ICollection<Shipment> ShipmentShipperParties { get; set; }
        public virtual ICollection<Shipment> ShipmentToParties { get; set; }
    }
}
