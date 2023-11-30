using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ProcurementRfqbidItem
    {
        public ProcurementRfqbidItem()
        {
            ProcurementPurchaseOrderItems = new HashSet<ProcurementPurchaseOrderItem>();
        }

        public string Id { get; set; } = null!;
        public decimal AmountAvailable { get; set; }
        public string? BrandName { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeliveryDatePossible { get; set; }
        public string? DescriptionRfqbidItem { get; set; }
        public bool IsDeleted { get; set; }
        public string? Model { get; set; }
        public string? PscategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? ProcurementRfqbidId { get; set; }
        public string? ProcurementRfqid { get; set; }
        public string? ProcurementRequestId { get; set; }
        public string? StateId { get; set; }
        public string? SupplierId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ValidityDeadlineDate { get; set; }
        public decimal TaxPercent { get; set; }
        public string? PaymentMethodType { get; set; }
        public string? PaymentModelType { get; set; }
        public string Psid { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }

        public virtual ProcurementRequest? ProcurementRequest { get; set; }
        public virtual ProcurementRfqbid? ProcurementRfqbid { get; set; }
        public virtual Pss Ps { get; set; } = null!;
        public virtual Pscategory? Pscategory { get; set; }
        public virtual Party? Supplier { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; }
    }
}
