import { Injectable } from "@angular/core";
import { BaseEntity } from "../../common/BaseEntity";

@Injectable()
export class PlannedOfferForm extends BaseEntity {



  SalesOfferNumber: string = null!;
  RevisionNumber: number = null!;
  ExchangeRate: number = null!;
  OfferTonnage: number = null!;
  DailyTonnage: number = null!;
  NumberEmployees: number = null!;
  IsgexpertCost: number = null!;
  FieldEngineerCost: number = null!;
  DailyWageAmount: number = null!;
  NumberDays: number = null!;
  AccommodationUnitPrice: number = null!;
  StaffMealUnitPrice: number = null!;
  RentedCarUnitPrice: number = null!;
  AccommodationTotalPrice: number = null!;
  InstallationTotalCost: number = null!;
  NumberTrucksUsed: number = null!;
  TruckUnitPrice: number = null!;
  ShippingTotalCost: number = null!;
  ShippingTotalCostCurrency: number = null!;
  InstallationTotalCostCurrency: number = null!;
  RentedCarAmount: number = null!;
  FuelUnitPrice: number = null!;
  FuelAmount: number = null!;
  FuelTotalCost: number = null!;
  StaffMealTotalPrice: number = null!;
  RentedCarUnitTotalPrice: number = null!;
  ShippingInstallationCostumerId: string = null!;
  ShippingInstallationCostumerName: string = null!;
  ShippingInstallationCostumerCity: string = null!;
  RentedEquipmentId: string = null!;
  RentedEquipmentName: string = null!;
  RentedEquipmentDailyCost: number = 0;
  RentedEquipmentMonthlyCost: number = 0;
  RentedEquipmentAmount: number = null!;
  RentedEquipmentTotalCost: number = null!;


  CasualtyRate: number = 0.96;//zahiyat oranı default değer







}
