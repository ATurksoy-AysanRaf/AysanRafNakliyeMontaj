using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            Departments = new HashSet<Department>();
            EmploymentTaskTypes = new HashSet<EmploymentTaskType>();
            Employments = new HashSet<Employment>();
            ExpenseRecordGroups = new HashSet<ExpenseRecordGroup>();
            ExpenseRecords = new HashSet<ExpenseRecord>();
            InAppNotificationCreatedUsers = new HashSet<InAppNotification>();
            InAppNotificationToUsers = new HashSet<InAppNotification>();
            InventoryItemTransactions = new HashSet<InventoryItemTransaction>();
            Parties = new HashSet<Party>();
            ProcurementPurchaseOrders = new HashSet<ProcurementPurchaseOrder>();
            ProcurementRequestApprovedUsers = new HashSet<ProcurementRequest>();
            ProcurementRequestCanceledUsers = new HashSet<ProcurementRequest>();
            ProcurementRequestCreatedUsers = new HashSet<ProcurementRequest>();
            ProcurementRequestRejectedUsers = new HashSet<ProcurementRequest>();
            ProcurementRequestUpdatedUsers = new HashSet<ProcurementRequest>();
            ProcurementRfqbids = new HashSet<ProcurementRfqbid>();
            ProcurementRfqs = new HashSet<ProcurementRfq>();
            ProcurementUserNotificationSettings = new HashSet<ProcurementUserNotificationSetting>();
            SalesCustomerMeetingFormCreatedUsers = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormProjectManagerUsers = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormSalesManagerUsers = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormSalesPersonUsers = new HashSet<SalesCustomerMeetingForm>();
            SalesCustomerMeetingFormUpdatedUsers = new HashSet<SalesCustomerMeetingForm>();
            SalesOfferCreatedUsers = new HashSet<SalesOffer>();
            SalesOfferProjectDesignerUsers = new HashSet<SalesOffer>();
            SalesOfferProjectManagerUsers = new HashSet<SalesOffer>();
            SalesOfferSalesManagerUsers = new HashSet<SalesOffer>();
            SalesOfferSalesPersonUsers = new HashSet<SalesOffer>();
            SalesOfferUpdatedUsers = new HashSet<SalesOffer>();
            SalesOrderCreatedUsers = new HashSet<SalesOrder>();
            SalesOrderInvoices = new HashSet<SalesOrderInvoice>();
            SalesOrderPaymentPlanSteps = new HashSet<SalesOrderPaymentPlanStep>();
            SalesOrderProductionDirectorUsers = new HashSet<SalesOrder>();
            SalesOrderProductionManagerUsers = new HashSet<SalesOrder>();
            SalesOrderProductionPlannerUsers = new HashSet<SalesOrder>();
            SalesOrderProjectDesignerUsers = new HashSet<SalesOrder>();
            SalesOrderProjectManagerUsers = new HashSet<SalesOrder>();
            SalesOrderSalesManagerUsers = new HashSet<SalesOrder>();
            SalesOrderSalesPersonUsers = new HashSet<SalesOrder>();
            SalesOrderUpdatedUsers = new HashSet<SalesOrder>();
            SalesPersonRevenueGoals = new HashSet<SalesPersonRevenueGoal>();
            ShipmentAmountBasedPlanCreatedUsers = new HashSet<ShipmentAmountBasedPlan>();
            ShipmentAmountBasedPlanUpdatedUsers = new HashSet<ShipmentAmountBasedPlan>();
            ShipmentCreatedUsers = new HashSet<Shipment>();
            ShipmentItemCreatedUsers = new HashSet<ShipmentItem>();
            ShipmentItemUpdatedUsers = new HashSet<ShipmentItem>();
            ShipmentShipmentManagerUsers = new HashSet<Shipment>();
            ShipmentShipmentPersonUsers = new HashSet<Shipment>();
            ShipmentShipmentPlannerUsers = new HashSet<Shipment>();
            ShipmentUpdatedUsers = new HashSet<Shipment>();
            StockCountingActivityCreatedUsers = new HashSet<StockCountingActivity>();
            StockCountingActivityUpdatedUsers = new HashSet<StockCountingActivity>();
            TaskActivityApprovedUsers = new HashSet<TaskActivity>();
            TaskActivityCreatedUsers = new HashSet<TaskActivity>();
            TaskActivityEmployees = new HashSet<TaskActivityEmployee>();
            TaskActivityQcmeasurements = new HashSet<TaskActivityQcmeasurement>();
            TaskActivityUpdatedUsers = new HashSet<TaskActivity>();
            TaskActivityUser2s = new HashSet<TaskActivity>();
            TaskActivityUser3s = new HashSet<TaskActivity>();
            TaskActivityUser4s = new HashSet<TaskActivity>();
            TaskActivityUser5s = new HashSet<TaskActivity>();
            TaskActivityUser6s = new HashSet<TaskActivity>();
            TaskActivityUsers = new HashSet<TaskActivity>();
            TaskNotes = new HashSet<TaskNote>();
            Tasks = new HashSet<Task>();
            Roles = new HashSet<AspNetRole>();
        }

        public string Id { get; set; } = null!;
        public int AccessFailedCount { get; set; }
        public string? BirthDate { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string FirstName { get; set; } = null!;
        public string? ImageAvatarLogoBase64 { get; set; }
        public string? ImageBase64 { get; set; }
        public bool IsDeleted { get; set; }
        public string LastName { get; set; } = null!;
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public string? MarriageFamilyName { get; set; }
        public string? MidName { get; set; }
        public string? NormalizedEmail { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string? PreviousUserId { get; set; }
        public string? PrimaryCountryCodeIso3 { get; set; }
        public string? PrimaryLanguageCodeIso3 { get; set; }
        public string? SecurityStamp { get; set; }
        public string? TenantId { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string? UserName { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<EmploymentTaskType> EmploymentTaskTypes { get; set; }
        public virtual ICollection<Employment> Employments { get; set; }
        public virtual ICollection<ExpenseRecordGroup> ExpenseRecordGroups { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<InAppNotification> InAppNotificationCreatedUsers { get; set; }
        public virtual ICollection<InAppNotification> InAppNotificationToUsers { get; set; }
        public virtual ICollection<InventoryItemTransaction> InventoryItemTransactions { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
        public virtual ICollection<ProcurementPurchaseOrder> ProcurementPurchaseOrders { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequestApprovedUsers { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequestCanceledUsers { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequestCreatedUsers { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequestRejectedUsers { get; set; }
        public virtual ICollection<ProcurementRequest> ProcurementRequestUpdatedUsers { get; set; }
        public virtual ICollection<ProcurementRfqbid> ProcurementRfqbids { get; set; }
        public virtual ICollection<ProcurementRfq> ProcurementRfqs { get; set; }
        public virtual ICollection<ProcurementUserNotificationSetting> ProcurementUserNotificationSettings { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormCreatedUsers { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormProjectManagerUsers { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormSalesManagerUsers { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormSalesPersonUsers { get; set; }
        public virtual ICollection<SalesCustomerMeetingForm> SalesCustomerMeetingFormUpdatedUsers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferCreatedUsers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferProjectDesignerUsers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferProjectManagerUsers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferSalesManagerUsers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferSalesPersonUsers { get; set; }
        public virtual ICollection<SalesOffer> SalesOfferUpdatedUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderCreatedUsers { get; set; }
        public virtual ICollection<SalesOrderInvoice> SalesOrderInvoices { get; set; }
        public virtual ICollection<SalesOrderPaymentPlanStep> SalesOrderPaymentPlanSteps { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderProductionDirectorUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderProductionManagerUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderProductionPlannerUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderProjectDesignerUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderProjectManagerUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderSalesManagerUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderSalesPersonUsers { get; set; }
        public virtual ICollection<SalesOrder> SalesOrderUpdatedUsers { get; set; }
        public virtual ICollection<SalesPersonRevenueGoal> SalesPersonRevenueGoals { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlanCreatedUsers { get; set; }
        public virtual ICollection<ShipmentAmountBasedPlan> ShipmentAmountBasedPlanUpdatedUsers { get; set; }
        public virtual ICollection<Shipment> ShipmentCreatedUsers { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItemCreatedUsers { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItemUpdatedUsers { get; set; }
        public virtual ICollection<Shipment> ShipmentShipmentManagerUsers { get; set; }
        public virtual ICollection<Shipment> ShipmentShipmentPersonUsers { get; set; }
        public virtual ICollection<Shipment> ShipmentShipmentPlannerUsers { get; set; }
        public virtual ICollection<Shipment> ShipmentUpdatedUsers { get; set; }
        public virtual ICollection<StockCountingActivity> StockCountingActivityCreatedUsers { get; set; }
        public virtual ICollection<StockCountingActivity> StockCountingActivityUpdatedUsers { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityApprovedUsers { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityCreatedUsers { get; set; }
        public virtual ICollection<TaskActivityEmployee> TaskActivityEmployees { get; set; }
        public virtual ICollection<TaskActivityQcmeasurement> TaskActivityQcmeasurements { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUpdatedUsers { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUser2s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUser3s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUser4s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUser5s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUser6s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityUsers { get; set; }
        public virtual ICollection<TaskNote> TaskNotes { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public virtual ICollection<AspNetRole> Roles { get; set; }
    }
}
