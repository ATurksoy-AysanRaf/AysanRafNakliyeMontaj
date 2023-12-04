using System;
using System.Collections.Generic;

namespace Models
{
    public partial class SalesOfferTermsDefaultValue
    {
        public string TenantId { get; set; } = null!;
        public string? CreatedDate { get; set; }
        public string? CreatedUserEmail { get; set; }
        public string? CreatedUserFullName { get; set; }
        public string? CreatedUserId { get; set; }
        public string? DescriptionColor { get; set; }
        public string? DescriptionDeliveryAddress { get; set; }
        public string? DescriptionDeliveryDate { get; set; }
        public string? DescriptionInstallation { get; set; }
        public string? DescriptionPayment { get; set; }
        public string? DescriptionSalesTerms { get; set; }
        public string? DescriptionStandarts { get; set; }
        public string? DescriptionTax { get; set; }
        public string? DescriptionWarranty { get; set; }
        public string? DescriptionWeight { get; set; }
        public bool IsDeleted { get; set; }
        public string? StateId { get; set; }
        public string? ThanksToCustomer { get; set; }
        public string? UpdatedDate { get; set; }
        public string? UpdatedUserEmail { get; set; }
        public string? UpdatedUserFullName { get; set; }
        public string? UpdatedUserId { get; set; }
        public int ValidityDeadlineDays { get; set; }
    }
}
