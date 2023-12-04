using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ProcurementRfqbid
    {
        public ProcurementRfqbid()
        {
            ProcurementPurchaseOrders = new HashSet<ProcurementPurchaseOrder>();
            ProcurementRfqbidItems = new HashSet<ProcurementRfqbidItem>();
        }

        public string Id { get; set; } = null!;
        public string? AccessCode { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public bool IsDeleted { get; set; }
        public short PaymentAfterDeliveryDueDays { get; set; }
        public decimal PaymentAfterDeliveryPrice { get; set; }
        public short PaymentAfterInvoiceDueDays { get; set; }
        public decimal PaymentAfterInvoicePrice { get; set; }
        public short PaymentAfterOrderDueDays { get; set; }
        public decimal PaymentAfterOrderPrice { get; set; }
        public int PaymentInstallmentCount { get; set; }
        public short PaymentInstallmentPeriodMonths { get; set; }
        public string? PaymentMethodType { get; set; }
        public string? PaymentModelType { get; set; }
        public decimal PriceProductServiceTotal { get; set; }
        public decimal PriceShipment { get; set; }
        public decimal PriceTotal { get; set; }
        public string? ProcurementRfqid { get; set; }
        public string? ProviderPersonEmail { get; set; }
        public string? ProviderPersonFirstName { get; set; }
        public string? ProviderPersonLastName { get; set; }
        public string? ProviderPersonPosition { get; set; }
        public string? StateId { get; set; }
        public string? SupplierId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ValidityDeadlineDate { get; set; }
        public string? DescriptionRfqbid { get; set; }
        public int PaymentMilestoneCount { get; set; }
        public decimal PaymentMilestonePrice { get; set; }
        public decimal PriceDiscount { get; set; }
        public short PaymentAfterMilestoneDeliveryDueDays { get; set; }
        public string? DeadlineDateRfqbid { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentPurchaseContractName { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual ProcurementRfq? ProcurementRfq { get; set; }
        public virtual Party? Supplier { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual ICollection<ProcurementPurchaseOrder> ProcurementPurchaseOrders { get; set; }
        public virtual ICollection<ProcurementRfqbidItem> ProcurementRfqbidItems { get; set; }
    }
}
