using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class ReminderNotificationLog
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public int Day { get; set; }
        public int DayOfWeek { get; set; }
        public int Hour { get; set; }
        public bool IsDeleted { get; set; }
        public int Minute { get; set; }
        public int Month { get; set; }
        public string? NotificationToEmail { get; set; }
        public string? NotificationToUserId { get; set; }
        public string? NotificationTypeId { get; set; }
        public string? ReminderTypeId { get; set; }
        public string? StateId { get; set; }
        public string? TenantId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public int Year { get; set; }
    }
}
