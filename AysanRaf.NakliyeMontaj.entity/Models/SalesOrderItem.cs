using System;
using System.Collections.Generic;

namespace Models
{
    public partial class SalesOrderItem
    {
        public SalesOrderItem()
        {
            InventoryItems = new HashSet<InventoryItem>();
            SalesOrderItemComponents = new HashSet<SalesOrderItemComponent>();
            Tasks = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? CurrencyDefault { get; set; }
        public string? CustomerId { get; set; }
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public string? PscategoryId { get; set; }
        public string? Psid { get; set; }
        public string? SalesOrderId { get; set; }
        public string? StateId { get; set; }
        public decimal TaxPercent { get; set; }
        public string? TenantId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? ExchangeDate { get; set; }
        public decimal UnitPriceDefault { get; set; }
        public decimal AmountInvoice { get; set; }
        public decimal AmountRevision { get; set; }
        public decimal AmountRevisionInvoice { get; set; }
        public string? ProjectId { get; set; }
        public string? RevisionPriceExchangeTypeId { get; set; }
        public string? RevReason { get; set; }
        public string? RevParty { get; set; }
        public string? RevType { get; set; }

        public virtual Party? Customer { get; set; }
        public virtual Project? Project { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual Pscategory? Pscategory { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<SalesOrderItemComponent> SalesOrderItemComponents { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
