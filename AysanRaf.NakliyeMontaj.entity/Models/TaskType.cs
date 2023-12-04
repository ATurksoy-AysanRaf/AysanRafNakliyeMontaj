using System;
using System.Collections.Generic;

namespace Models
{
    public partial class TaskType
    {
        public TaskType()
        {
            AssetUsedTaskTypes = new HashSet<AssetUsedTaskType>();
            EmploymentTaskTypes = new HashSet<EmploymentTaskType>();
            ExpenseRecords = new HashSet<ExpenseRecord>();
            ExpenseTypes = new HashSet<ExpenseType>();
            PscategoryTaskTypes = new HashSet<PscategoryTaskType>();
            PscomponentTaskTypeExcludes = new HashSet<PscomponentTaskTypeExclude>();
            TaskActivities = new HashSet<TaskActivity>();
            TaskActivityQcmeasurements = new HashSet<TaskActivityQcmeasurement>();
            Tasks = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public bool AddAutoPsc { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? ReverseId { get; set; }
        public int Sno { get; set; }
        public string? SiteId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? TypeId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public bool AddAutoSo { get; set; }

        public virtual ICollection<AssetUsedTaskType> AssetUsedTaskTypes { get; set; }
        public virtual ICollection<EmploymentTaskType> EmploymentTaskTypes { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<ExpenseType> ExpenseTypes { get; set; }
        public virtual ICollection<PscategoryTaskType> PscategoryTaskTypes { get; set; }
        public virtual ICollection<PscomponentTaskTypeExclude> PscomponentTaskTypeExcludes { get; set; }
        public virtual ICollection<TaskActivity> TaskActivities { get; set; }
        public virtual ICollection<TaskActivityQcmeasurement> TaskActivityQcmeasurements { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
