using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ProcurementRequest
    {
        public ProcurementRequest()
        {
            ProcurementPurchaseOrderItems = new HashSet<ProcurementPurchaseOrderItem>();
            ProcurementRequestMedia = new HashSet<ProcurementRequestMedia>();
            ProcurementRfqbidItems = new HashSet<ProcurementRfqbidItem>();
        }

        public string Id { get; set; } = null!;
        public string? AddressRequest { get; set; }
        public decimal AmountRequest { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DeadlineDateRequest { get; set; }
        public string? DescriptionRequest { get; set; }
        public bool IsDeleted { get; set; }
        public string? PscategoryId { get; set; }
        public string? ProjectOrderId { get; set; }
        public string? Purpose { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public decimal AmountRequestRemaining { get; set; }
        public string Psid { get; set; } = null!;
        public string? ApprovedUserId { get; set; }
        public string? CanceledUserId { get; set; }
        public string? RejectedUserId { get; set; }
        public string? ApprovedDate { get; set; }
        public string? CanceledDate { get; set; }
        public string? RejectedDate { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public string? SalesOrderId { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }

        public virtual AspNetUser? ApprovedUser { get; set; }
        public virtual AspNetUser? CanceledUser { get; set; }
        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? Customer { get; set; }
        public virtual Pss Ps { get; set; } = null!;
        public virtual Pscategory? Pscategory { get; set; }
        public virtual AspNetUser? RejectedUser { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual ICollection<ProcurementPurchaseOrderItem> ProcurementPurchaseOrderItems { get; set; }
        public virtual ICollection<ProcurementRequestMedia> ProcurementRequestMedia { get; set; }
        public virtual ICollection<ProcurementRfqbidItem> ProcurementRfqbidItems { get; set; }
    }
}
