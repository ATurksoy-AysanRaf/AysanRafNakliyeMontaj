﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Entites.DTOs
{
    public class RealizedOfferFormForDetailDto
    {
        public string SalesOfferNumber { get; set; } = null!;
        public int RevisionNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int ExchangeRate { get; set; }

        public int CasualtyRate { get; set; }
        public int DailyWageCost { get; set; }
        public int ReallyTonnage { get; set; }
        public int OfferTonnage { get; set; }
        public int DailyTonnage { get; set; }
        public int NumberEmployees { get; set; }
        public int IsgexpertCost { get; set; }
        public int FieldEngineerCost { get; set; }





        public int DailyWageAmount { get; set; }
        public int WageTotalCost { get; set; }
        public int NumberDays { get; set; }



        public int? EquipmentShipmentCost { get; set; }
        public int? EquipmentSumtCost { get; set; }



        public int AccommodationUnitPrice { get; set; }
        public int AccommodationTotalPrice { get; set; }



        public int StaffMealTotalPrice { get; set; }
        public int StaffMealUnitPrice { get; set; }


        public int TotalCarFuelCost { get; set; }


        public int InstallationTotalCost { get; set; }
        public int InstallationTotalCostCurrency { get; set; }




        public int NumberTrucksUsed { get; set; }
        public int TruckUnitPrice { get; set; }



        public int ShippingTotalCost { get; set; }
        public int ShippingTotalCostCurrency { get; set; }






        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? CustomerCity { get; set; }


        public string? RentedEquipmentId { get; set; }
        public string? RentedEquipmentName { get; set; }
    }
}