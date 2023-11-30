using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Department
    {
        public Department()
        {
            Employments = new HashSet<Employment>();
            InverseParentDepartment = new HashSet<Department>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string? ManagerUserId { get; set; }
        public string Name { get; set; } = null!;
        public string? OrganizationId { get; set; }
        public string? ParentDepartmentId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual AspNetUser? ManagerUser { get; set; }
        public virtual Party? Organization { get; set; }
        public virtual Department? ParentDepartment { get; set; }
        public virtual ICollection<Employment> Employments { get; set; }
        public virtual ICollection<Department> InverseParentDepartment { get; set; }
    }
}
