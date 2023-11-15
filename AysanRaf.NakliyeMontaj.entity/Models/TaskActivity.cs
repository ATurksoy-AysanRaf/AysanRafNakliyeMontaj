using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class TaskActivity
    {
        public TaskActivity()
        {
            ExpenseRecords = new HashSet<ExpenseRecord>();
            TaskActivityAssets = new HashSet<TaskActivityAsset>();
            TaskActivityEmployees = new HashSet<TaskActivityEmployee>();
            TaskActivityInventoryItems = new HashSet<TaskActivityInventoryItem>();
            TaskActivityQcmeasurements = new HashSet<TaskActivityQcmeasurement>();
        }

        public string Id { get; set; } = null!;
        public decimal AmortisationCost { get; set; }
        public decimal AmountDefective { get; set; }
        public decimal AmountDone { get; set; }
        public string? CostTypeId { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? Currency { get; set; }
        public string? DefectReasonTypeId { get; set; }
        public string? DefectResponsibleTypeId { get; set; }
        public int Duration { get; set; }
        public decimal ElectricityCost { get; set; }
        public string? EndDate { get; set; }
        public decimal FuelCost { get; set; }
        public decimal GasCost { get; set; }
        public bool IsDeleted { get; set; }
        public decimal LaborCost { get; set; }
        public string? MachineId { get; set; }
        public string? Note { get; set; }
        public string? StartDate { get; set; }
        public string? StateId { get; set; }
        public string? TaskId { get; set; }
        public string? TaskTypeId { get; set; }
        public string? TenantId { get; set; }
        public string? TypeId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? UserId { get; set; }
        public decimal MaterialCost { get; set; }
        public string? User2Id { get; set; }
        public string? User3Id { get; set; }
        public string? User4Id { get; set; }
        public string? User5Id { get; set; }
        public string? User6Id { get; set; }
        public string? ApprovedUserId { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ExpenseRecordGroupId { get; set; }
        public string? ProjectId { get; set; }
        public string? Sono { get; set; }
        public int SorevNo { get; set; }
        public string? SalesOrderId { get; set; }
        public string? TaskNo { get; set; }
        public string? Town { get; set; }
        public string? Machine2Id { get; set; }
        public string? Machine3Id { get; set; }
        public string? Machine4Id { get; set; }

        public virtual AspNetUser? ApprovedUser { get; set; }
        public virtual AspNetUser? CreatedUser { get; set; }
        public virtual Asset? Machine { get; set; }
        public virtual Asset? Machine2 { get; set; }
        public virtual Asset? Machine3 { get; set; }
        public virtual Asset? Machine4 { get; set; }
        public virtual Task? Task { get; set; }
        public virtual TaskType? TaskType { get; set; }
        public virtual AspNetUser? UpdatedUser { get; set; }
        public virtual AspNetUser? User { get; set; }
        public virtual AspNetUser? User2 { get; set; }
        public virtual AspNetUser? User3 { get; set; }
        public virtual AspNetUser? User4 { get; set; }
        public virtual AspNetUser? User5 { get; set; }
        public virtual AspNetUser? User6 { get; set; }
        public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
        public virtual ICollection<TaskActivityAsset> TaskActivityAssets { get; set; }
        public virtual ICollection<TaskActivityEmployee> TaskActivityEmployees { get; set; }
        public virtual ICollection<TaskActivityInventoryItem> TaskActivityInventoryItems { get; set; }
        public virtual ICollection<TaskActivityQcmeasurement> TaskActivityQcmeasurements { get; set; }
    }
}
