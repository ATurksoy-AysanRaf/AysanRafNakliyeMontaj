using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class SalesOfferInternalFile
    {
        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public int DisplayOrder { get; set; }
        public string? FileName { get; set; }
        public bool IsDeleted { get; set; }
        public int MediaType { get; set; }
        public string? SalesOfferId { get; set; }
        public string? StateId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }

        public virtual SalesOffer? SalesOffer { get; set; }
    }
}
