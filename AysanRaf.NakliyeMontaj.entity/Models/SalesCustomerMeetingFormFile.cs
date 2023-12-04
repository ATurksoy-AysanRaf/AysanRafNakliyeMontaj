using System;
using System.Collections.Generic;

namespace Models
{
    public partial class SalesCustomerMeetingFormFile
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public int DisplayOrder { get; set; }
        public string? FileName { get; set; }
        public bool IsDeleted { get; set; }
        public int MediaType { get; set; }
        public string? SalesCustomerMeetingFormId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual SalesCustomerMeetingForm? SalesCustomerMeetingForm { get; set; }
    }
}
