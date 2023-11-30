using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ShipmentItem
    {
        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal AmountAccepted { get; set; }
        public decimal AmountRejected { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public string? Psid { get; set; }
        public string? PurchaseUnit { get; set; }
        public string? ShipmentId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public decimal AmountDamaged { get; set; }
        public string? DamageReasonTypeId { get; set; }
        public string? FromPartyId { get; set; }
        public string? InventoryItemId { get; set; }
        public string? MismatchReasonTypeId { get; set; }
        public string? ProjectId { get; set; }
        public string? RejectionReasonTypeId { get; set; }
        public string? SalesOrderId { get; set; }
        public string? ShipmentItemNumber { get; set; }
        public string? TaskId { get; set; }
        public string? ToPartyId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Party? FromParty { get; set; }
        public virtual InventoryItem? InventoryItem { get; set; }
        public virtual Project? Project { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual Shipment? Shipment { get; set; }
        public virtual Task? Task { get; set; }
        public virtual Party? ToParty { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
    }
}
