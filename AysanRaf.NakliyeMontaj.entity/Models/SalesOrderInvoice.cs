using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOrderInvoice
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Date { get; set; }
        public string? FileName { get; set; }
        public bool IsDeleted { get; set; }
        public int MediaType { get; set; }
        public string? No { get; set; }
        public string? Note { get; set; }
        public string? SalesOrderId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
    }
}
