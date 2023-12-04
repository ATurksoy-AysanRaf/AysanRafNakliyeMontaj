using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            ExpenseRecords = new HashSet<ExpenseRecord>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? ExpenseCategoryId { get; set; }
        public string? IntegrationCode { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? StateId { get; set; }
        public string? TaskTypeId { get; set; }
        public string? TaskTypeTypeId { get; set; }
        public decimal TaxRate { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? TypeId { get; set; }

        public virtual ExpenseCategory? ExpenseCategory { get; set; }
        public virtual TaskType? TaskType { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
    }
}
