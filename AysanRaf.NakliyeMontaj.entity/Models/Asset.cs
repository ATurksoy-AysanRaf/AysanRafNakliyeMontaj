using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Asset
    {
        public Asset()
        {
            AssetUsedTaskTypes = new HashSet<AssetUsedTaskType>();
            ExpenseRecords = new HashSet<ExpenseRecord>();
            TaskActivityAssets = new HashSet<TaskActivityAsset>();
            TaskActivityMachine2s = new HashSet<TaskActivity>();
            TaskActivityMachine3s = new HashSet<TaskActivity>();
            TaskActivityMachine4s = new HashSet<TaskActivity>();
            TaskActivityMachines = new HashSet<TaskActivity>();
            Tasks = new HashSet<Task>();
        }

        public string Id { get; set; } = null!;
        public decimal AmortizationPerHour { get; set; }
        public string? ChasisNumber { get; set; }
        public string? Code { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public decimal ElectricityPerHour { get; set; }
        public string? EngineNumber { get; set; }
        public decimal FuelPerHour { get; set; }
        public decimal GasPerHour { get; set; }
        public string? InventoryItemId { get; set; }
        public bool IsDeleted { get; set; }
        public string? LicenseNumber { get; set; }
        public string? Name { get; set; }
        public string? Psid { get; set; }
        public string? PlateNumber { get; set; }
        public string? PurchaseLeaseTypeId { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? TypeId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual InventoryItem? InventoryItem { get; set; }
        public virtual Pss? Ps { get; set; }
        public virtual ICollection<AssetUsedTaskType> AssetUsedTaskTypes { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<TaskActivityAsset> TaskActivityAssets { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityMachine2s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityMachine3s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityMachine4s { get; set; }
        public virtual ICollection<TaskActivity> TaskActivityMachines { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
