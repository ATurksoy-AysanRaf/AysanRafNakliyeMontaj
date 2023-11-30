using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class ExpenseRecordGroup
    {
        public ExpenseRecordGroup()
        {
            ExpenseRecords = new HashSet<ExpenseRecord>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int SeqNo { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? EmployeeUserId { get; set; }
        public string? EndDate { get; set; }
        public string? StartDate { get; set; }
        public string? Currency { get; set; }
        public decimal Price { get; set; }

        public virtual AspNetUser? EmployeeUser { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
    }
}
