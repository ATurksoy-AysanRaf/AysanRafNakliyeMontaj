using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            ExpenseTypes = new HashSet<ExpenseType>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual ICollection<ExpenseType> ExpenseTypes { get; set; }
    }
}
