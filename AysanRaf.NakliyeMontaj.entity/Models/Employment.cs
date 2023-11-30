using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Employment
    {
        public string EmployerId { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public string? Code { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? DateEnd { get; set; }
        public string? DateStart { get; set; }
        public string? DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
        public decimal SalaryGrossMonthly { get; set; }
        public string? StateId { get; set; }
        public string? Title { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual AspNetUser Employee { get; set; } = null!;
        public virtual Party Employer { get; set; } = null!;
    }
}
