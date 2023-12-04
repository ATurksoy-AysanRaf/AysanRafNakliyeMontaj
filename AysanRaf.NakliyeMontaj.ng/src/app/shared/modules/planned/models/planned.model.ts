import { Injectable } from "@angular/core";
import { BaseEntity } from "../../common/BaseEntity";

@Injectable()
export class PlannedOfferForm extends BaseEntity {

 
  SalesOfferNumber: number = null!;
  revisionNumber: number = null!;
  ExchangeRate: number = null!;
  reallyTonage: number = null!;
  offerTonnage: number = null!;
  dailyTonnage: number = null!;
  numberEmployees: number = null!;
  isgexpertCost: number = null!;
  fieldEngineerCost: number = null!;
  dailyWageAmount: number = null!;
  numberDays: number = null!;
  accommodationUnitPrice: number = null!;
  staffMealUnitPrice: number = null!;
  rentedCarUnitPrice: number = null!;
  accommodationTotalPrice: number = null!;
  installationTotalCost: number = null!;
  numberTrucksUsed: number = null!;
  truckUnitPrice: number = null!;
  shippingTotalCost: number = null!;
  shippingTotalCostCurrency: number = null!;
  installationTotalCostCurrency: number = null!;
  city: string = null!;
  staffMealTotalPrice: number = null!;
  rentedCarUnitTotalPrice: number = null!;
  shippingInstallationCostumerId: string = null!;
  shippingInstallationCostumerName: string = null!;
  shippingInstallationCostumerCity: string = null!;
  equipmentSumCost: number = null!;
  rentedEquipmentId: string = null!;
  rentedEquipmentName: string = null!;
  rentedEquipmentDailyCost: number = 0;
  rentedEquipmentMonthlyCost: number = 0;
  rentedEquipmentAmount: number = null!;
  rentedEquipmentTotalCost: number = null!;


  casualtyRate: number = 0.96;//zahiyat oranı default değer







}
