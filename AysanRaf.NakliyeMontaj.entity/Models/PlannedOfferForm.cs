using System;
using System.Collections.Generic;

namespace AysanRaf.NakliyeMontaj.app.Models
{
    public partial class PlannedOfferForm
    {
        public string Id { get; set; } = null!;
        public string SalesOfferNumber { get; set; } = null!;
        public int RevisionNumber { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string ExchangeRate { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string DailyWageCost { get; set; } = null!;
        public string OfferTonnage { get; set; } = null!;
        public string DailyTonnage { get; set; } = null!;
        public int NumberEmployees { get; set; }
        public string IsgexpertCost { get; set; } = null!;
        public string FieldEngineerCost { get; set; } = null!;
        public int DailyWageAmount { get; set; }
        public int NumberDays { get; set; }
        public string? RentedEquipmentId { get; set; }
        public string? RentedEquipmentName { get; set; }
        public string? EquipmentShipmentCost { get; set; }
        public string AccommodationUnitPrice { get; set; } = null!;
        public string StaffMealUnitPrice { get; set; } = null!;
        public string RentedCarUnitPrice { get; set; } = null!;
        public string AccommodationTotalPrice { get; set; } = null!;
        public string InstallationTotalCost { get; set; } = null!;
        public string NumberTrucksUsed { get; set; } = null!;
        public string TruckUnitPrice { get; set; } = null!;
        public string ShippingTotalCost { get; set; } = null!;
        public string ShippingTotalCostCurrency { get; set; } = null!;
        public string InstallationTotalCostCurrency { get; set; } = null!;
        public int RentedCarAmount { get; set; }
        public string FuelUnitPrice { get; set; } = null!;
        public string FuelAmount { get; set; } = null!;
        public string FuelTotalCost { get; set; } = null!;
        public string StaffMealTotalPrice { get; set; } = null!;
        public string RentedCarUnitTotalPrice { get; set; } = null!;
    }
}
