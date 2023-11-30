using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOrderItemComponent
    {
        public SalesOrderItemComponent()
        {
            Tasks = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public decimal AmountFulfilled { get; set; }
        public decimal AmountInStock { get; set; }
        public decimal AmountInstalled { get; set; }
        public decimal AmountRequired { get; set; }
        public decimal AmountSent { get; set; }
        public string? ComponentId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? SalesOrderId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public decimal AmountDefective { get; set; }
        public string? ProjectId { get; set; }
        public string? SalesOrderItemId { get; set; }

        public virtual Pss? Component { get; set; }
        public virtual Project? Project { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual SalesOrderItem? SalesOrderItem { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
