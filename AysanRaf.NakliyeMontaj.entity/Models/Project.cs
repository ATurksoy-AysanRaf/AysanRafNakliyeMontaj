using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class Project
    {
        public Project()
        {
            InventoryItems = new HashSet<InventoryItem>();
            SalesOrderItemComponents = new HashSet<SalesOrderItemComponent>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
            ShipmentItems = new HashSet<ShipmentItem>();
            Tasks = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public decimal Acost { get; set; }
        public int Aduration { get; set; }
        public string? Aend { get; set; }
        public string? Astart { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public decimal Pcost { get; set; }
        public int Pduration { get; set; }
        public string? Pend { get; set; }
        public string? Pstart { get; set; }
        public string? RevReason { get; set; }
        public string? RevParty { get; set; }
        public string? RevType { get; set; }
        public string? SalesOrderId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? TypeId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual Party? Tenant { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
        public virtual ICollection<SalesOrderItemComponent> SalesOrderItemComponents { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
