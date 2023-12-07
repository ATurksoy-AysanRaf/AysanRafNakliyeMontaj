using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PlannedOfferForm
    {
        public Guid Id { get; set; }
        public string SalesOfferNumber { get; set; } = null!;
        public string RevisionNumber { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public float ExchangeRate { get; set; }
        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public int DailyWageCost { get; set; }
        public int OfferTonnage { get; set; }
        public int DailyTonnage { get; set; }
        public int NumberEmployees { get; set; }
        public int IsgexpertCost { get; set; }
        public int FieldEngineerCost { get; set; }
        public int DailyWageAmount { get; set; }
        public float NumberDays { get; set; }
        public int? EquipmentShipmentCost { get; set; }
        public int AccommodationUnitPrice { get; set; }
        public int StaffMealUnitPrice { get; set; }
        public float AccommodationTotalPrice { get; set; }
        public float InstallationTotalCost { get; set; }
        public int TruckUnitPrice { get; set; }
        public float ShippingTotalCost { get; set; }
        public float ShippingTotalCostCurrency { get; set; }
        public float InstallationTotalCostCurrency { get; set; }
        public float StaffMealTotalPrice { get; set; }
        public int NumberTrucksUsed { get; set; }
        public float CasualtyRate { get; set; }
        public float ReallyTonnage { get; set; }
        public float WageTotalCost { get; set; }
        public float EquipmentSumCost { get; set; }
        public float? TotalCarFuelCost { get; set; }
        public string? CustomerCity { get; set; }
        public string? RentedEquipmentName1 { get; set; }
        public int? RentedEquipmentDailyCost1 { get; set; }
        public int? RentedEquipmentMonthlyCost1 { get; set; }
        public int? RentedEquipmentAmount1 { get; set; }
        public float? RentedEquipmentTotalCost1 { get; set; }
        public string? RentedEquipmentName2 { get; set; }
        public int? RentedEquipmentDailyCost2 { get; set; }
        public int? RentedEquipmentMonthlyCost2 { get; set; }
        public int? RentedEquipmentAmount2 { get; set; }
        public float? RentedEquipmentTotalCost2 { get; set; }
        public string? RentedEquipmentName3 { get; set; }
        public int? RentedEquipmentDailyCost3 { get; set; }
        public int? RentedEquipmentMonthlyCost3 { get; set; }
        public int? RentedEquipmentAmount3 { get; set; }
        public float? RentedEquipmentTotalCost3 { get; set; }
        public string? RentedEquipmentName4 { get; set; }
        public int? RentedEquipmentDailyCost4 { get; set; }
        public int? RentedEquipmentMonthlyCost4 { get; set; }
        public int? RentedEquipmentAmount4 { get; set; }
        public float? RentedEquipmentTotalCost4 { get; set; }
        public float? TotalWageAmount { get; set; }
    }
}
