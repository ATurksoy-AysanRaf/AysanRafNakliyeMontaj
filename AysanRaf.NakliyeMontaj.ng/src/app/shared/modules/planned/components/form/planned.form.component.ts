import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import {  ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialogRef } from "@angular/material/dialog";
import { FormBuilder, FormGroup } from "@angular/forms";
import { PlannedService } from "../../services/planned.service";
import { DataSource } from "@angular/cdk/collections";






@Component({
  selector: 'aysanraf-planned-form',
  templateUrl: './planned.form.component.html',
  styleUrls: ['./planned.form.component.scss']
})

export class PlannedFormComponent implements OnInit{
  @Input() formData: any; // Giriş olarak alınan veri


  PlannedOfferForm!: FormGroup ;

    


  constructor(private dialogRef: MatDialogRef<PlannedFormComponent>, private fb: FormBuilder, private dataService: PlannedService) {

    



  }

  close() {
    this.dialogRef.close();
  }


  ngOnInit(): void {

    



      this.PlannedOfferForm = this.fb.group({
        // Formunuzdaki alanları buraya ekleyin
   
        accommodationTotalPrice: [''],
        accommodationUnitPrice:[''],
        casualtyRate: [''],
        createdDate: [''],
        customerId: [''],
        customerName: [''],
        dailyTonnage: [''],
        dailyWageAmount: [''],
        dailyWageCost: [''],
        equipmentShipmentCost: [''],
        equipmentSumtCost: [''],
        exchangeRate: [''],
        fieldEngineerCost: [''],
        installationTotalCost: [''],
        installationTotalCostCurrency: [''],
        isgexpertCost: [''],
        numberDays: [''],
        numberEmployees: [''],
        numberTrucksUsed: [''],
        offerTonnage: [''],
        reallyTonnage: [''],
        rentedEquipmentId: [''],
        rentedEquipmentName: [''],
        salesOfferNumber: [''],
        shippingTotalCost: [''],
        shippingTotalCostCurrency: [''],
        staffMealTotalPrice: [''],
        staffMealUnitPrice: [''],
        totalCarFuelCost: [''],
        truckUnitPrice: [''],
        updatedDate: [''],
        wageTotalCost: [''],

      });

     

    // Verileri servisten al ve formu doldur
    this.dataService.getAllData().subscribe(
      (data) => {
        this.PlannedOfferForm.patchValue(data
         /* {*/
          //accommodationTotalPrice: data.accommodationTotalPrice,
          //accommodationUnitPrice: data.accommodationUnitPrice,
          //casualtyRate: data.casualtyRate,
          //createdDate: data.createdDate,
          //customerId: data.customerId,
          //customerName: data.customerName,
          //dailyTonnage: data.dailyTonnage,
          //dailyWageAmount: data.dailyWageAmount,
          //dailyWageCost: data.dailyWageCost,
          //equipmentShipmentCost: data.equipmentShipmentCost,
          //equipmentSumtCost: data.equipmentSumtCost,
          //exchangeRate: data.exchangeRate,
          //fieldEngineerCost: data.fieldEngineerCost,
          //installationTotalCost: data.installationTotalCost,
          //installationTotalCostCurrency: data.installationTotalCostCurrency,
          //isgexpertCost: data.isgexpertCost,
          //numberDays: data.numberDays,
          //numberEmployees: data.numberEmployees,
          //offerTonnage: data.offerTonnage,
          //reallyTonnage: data.reallyTonnage,
          //rentedEquipmentId: data.rentedEquipmentId,
          //rentedEquipmentName: data.rentedEquipmentName,
          //salesOfferNumber: data.salesOfferNumber,
          //shippingTotalCost: data.shippingTotalCost,
          //shippingTotalCostCurrency: data.shippingTotalCostCurrency,
          //staffMealTotalPrice: data.staffMealTotalPrice,
          //staffMealUnitPrice: data.staffMealUnitPrice,
          //totalCarFuelCost: data.totalCarFuelCost,
          //truckUnitPrice: data.truckUnitPrice,
          //updatedDate: data.updatedDate,
          //wageTotalCost: data.wageTotalCost,

      /*  }*/
    );
        console.log("okey", data);
        console.log("okey");
      },
      (error) => {
        console.error('Veri alınamadı:', error);
        console.log("hata");
      }
    );


    
    }

}

        //salesOfferNumber: [''],
        //CustomerName: [''],
        //City: [''],
        //CreatedDate: [''],
        //ExchangeRate: [''],

        //OfferTonnage: [''],
        //CasualtyRate: [''],
        //ReallyTonnage: [''],
        //DailyTonnage: [''],
        //FieldEngineerCost: [''],

        //DailyWageCost: [''],
        //DailyWageAmount: [''],
        //NumberDays: [''],
        //IsgexpertCost: [''],
        //WageTotalCost: [''],

        //rentedEquipmentName: [''],
        //rentedEquipmentDailyCost: [''],
        //rentedEquipmentMonthlyCost: [''],
        //rentedEquipmentAmount: [''],
        //rentedEquipmentTotalCost: [''],

        //EquipmentShipmentCost: [''],
        //EquipmentSumCost: [''],
        //AccommodationUnitPrice: [''],
        //AccommodationTotalPrice: [''],
        //StaffMealUnitPrice: [''],

        //StaffMealTotalPrice: [''],
        //TotalCarFuelCost: [''],
        //InstallationTotalCost: [''],
        //InstallationTotalCostCurrency: [''],
        //NumberTrucksUsed: [''],



        //TruckUnitPrice: [''],
        //ShippingTotalCost: [''],
        //ShippingTotalCostCurrency: [''],
