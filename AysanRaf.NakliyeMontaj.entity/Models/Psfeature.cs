using System;
using System.Collections.Generic;

namespace deneme.Models
{
    public partial class Psfeature
    {
        public Psfeature()
        {
            PscategoryTaskTypes = new HashSet<PscategoryTaskType>();
            PsfeatureValues = new HashSet<PsfeatureValue>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DataType { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; } = null!;
        public string? PscategoryId { get; set; }
        public string? StateId { get; set; }
        public string? UnitId { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserId { get; set; }
        public string? ValueType { get; set; }
        public decimal Max { get; set; }
        public decimal Min { get; set; }
        public string? Options { get; set; }
        public decimal Step { get; set; }
        public short DisplayOrder { get; set; }
        public bool? ShowInNameForCustomer { get; set; }

        public virtual Pscategory? Pscategory { get; set; }
        public virtual ICollection<PscategoryTaskType> PscategoryTaskTypes { get; set; }
        public virtual ICollection<PsfeatureValue> PsfeatureValues { get; set; }
    }
}
