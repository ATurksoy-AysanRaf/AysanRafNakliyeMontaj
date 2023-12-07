using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Entites.DTOs
{
    public class RealizedOfferFormForDetailDto
    {
        public Guid Id { get; set; }
        public string SalesOfferNumber { get; set; } = null!;
        public string RevisionNumber { get; set; } = "1";
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public float ExchangeRate { get; set; }

        public float CasualtyRate { get; set; }
        public float DailyWageCost { get; set; }
        public float ReallyTonnage { get; set; }
        public int OfferTonnage { get; set; }
        public int DailyTonnage { get; set; }
        public int NumberEmployees { get; set; }
        public int IsgexpertCost { get; set; }
        public int FieldEngineerCost { get; set; }


        public string rentedEquipmentName1 { get; set; }
        public int rentedEquipmentDailyCost1 { get; set; }
        public int rentedEquipmentMonthlyCost1 { get; set; }
        public int rentedEquipmentAmount1 { get; set; }
        public float rentedEquipmentTotalCost1 { get; set; }


        public string rentedEquipmentName2 { get; set; }
        public int rentedEquipmentDailyCost2 { get; set; }
        public int rentedEquipmentMonthlyCost2 { get; set; }
        public int rentedEquipmentAmount2 { get; set; }
        public float rentedEquipmentTotalCost2 { get; set; }

        public string rentedEquipmentName3 { get; set; }
        public int rentedEquipmentDailyCost3 { get; set; }
        public int rentedEquipmentMonthlyCost3 { get; set; }
        public int rentedEquipmentAmount3 { get; set; }
        public float rentedEquipmentTotalCost3 { get; set; }

        public string rentedEquipmentName4 { get; set; }
        public int rentedEquipmentDailyCost4 { get; set; }
        public int rentedEquipmentMonthlyCost4 { get; set; }
        public int rentedEquipmentAmount4 { get; set; }
        public float rentedEquipmentTotalCost4 { get; set; }




        public float DailyWageAmount { get; set; }
        public int WageTotalCost { get; set; }
        public int NumberDays { get; set; }



        public float? EquipmentShipmentCost { get; set; }
        public float? EquipmentSumCost { get; set; }



        public int AccommodationUnitPrice { get; set; }
        public float AccommodationTotalPrice { get; set; }



        public float StaffMealTotalPrice { get; set; }
        public int StaffMealUnitPrice { get; set; }


        public float TotalCarFuelCost { get; set; }


        public float InstallationTotalCost { get; set; }
        public float InstallationTotalCostCurrency { get; set; }




        public int NumberTrucksUsed { get; set; }
        public int TruckUnitPrice { get; set; }



        public float ShippingTotalCost { get; set; }
        public float ShippingTotalCostCurrency { get; set; }






        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? CustomerCity { get; set; }

        //public string? RentedEquipmentId { get; set; }
        //public string? RentedEquipmentName { get; set; }
    }
}