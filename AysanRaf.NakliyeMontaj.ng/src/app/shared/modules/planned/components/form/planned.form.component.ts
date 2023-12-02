import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialog, MatDialogRef } from "@angular/material/dialog";
import { FormBuilder, FormGroup } from "@angular/forms";
import { PlannedService } from "../../services/planned.service";
import { DataSource } from "@angular/cdk/collections";






@Component({
  selector: 'aysanraf-planned-form',
  templateUrl: './planned.form.component.html',
  styleUrls: ['./planned.form.component.scss']
})

export class PlannedFormComponent implements OnInit {



  PlannedOfferForm!: FormGroup;




  constructor(private dialog: MatDialog ,private dialogRef: MatDialogRef<PlannedFormComponent>, private fb: FormBuilder, private dataService: PlannedService) {


  }

  close() {
    this.dialogRef.close();
  }


  ngOnInit(): void {
    this.initializeForm();
    this.loadData();

  }

  initializeForm(): void {
    this.PlannedOfferForm = this.fb.group({
      // Formunuzdaki alanları buraya ekleyin

      accommodationTotalPrice: [''],
      accommodationUnitPrice: [''],
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
  }



  loadData(): void {
    // Verileri servisten al ve formu doldur
    this.dataService.getAllData().subscribe(
      (data) => {
        console.log('Received Data from API:', data);
        this.mapApiDataToForm(data);
      },
      (error) => {
        console.error('Veri alınamadı:', error);
      }
    );
  }

  //  openDialog(data: any) {
  //  this.dialog.open(PlannedFormComponent, {
  //    width: '4000px', // Genişlik
  //    height: '3000px', // Yükseklik
  //  });
  ////}

    openEditDialog() {
    this.dialog.open(PlannedFormComponent, {
      width: '4000px', // Genişlik
      height: '3000px', // Yükseklik
    });
  }

  mapApiDataToForm(data: any): void {
   /*  Formdaki kontrol adlarıyla API'den gelen veriyi eşleştir*/
    
    this.PlannedOfferForm.patchValue({
      salesOfferNumber: data[0].salesOfferNumber + "-" + data[0].revisionNumber,
      accommodationTotalPrice: data[0].accommodationTotalPrice,
      accommodationUnitPrice: data[0].accommodationUnitPrice,
      casualtyRate: data[0].casualtyRate,
      createdDate: data[0].createdDate,
      customerId: data[0].customerId,
      customerName: data[0].customerName,
      dailyTonnage: data[0].dailyTonnage,
      dailyWageAmount: data[0].dailyWageAmount,
      dailyWageCost: data[0].dailyWageCost,
      equipmentShipmentCost: data[0].equipmentShipmentCost,
      equipmentSumtCost: data[0].equipmentSumtCost,
      exchangeRate: data[0].exchangeRate,
      fieldEngineerCost: data[0].fieldEngineerCost,
      installationTotalCost: data[0].installationTotalCost,
      installationTotalCostCurrency: data[0].installationTotalCostCurrency,
      isgexpertCost: data[0].isgexpertCost,
      numberDays: data[0].numberDays,
      numberEmployees: data[0].numberEmployees,
      offerTonnage: data[0].offerTonnage,
      reallyTonnage: data[0].reallyTonnage,
      rentedEquipmentId: data[0].rentedEquipmentId,
      rentedEquipmentName: data[0].rentedEquipmentName,
      shippingTotalCost: data[0].shippingTotalCost,
      shippingTotalCostCurrency: data[0].shippingTotalCostCurrency,
      staffMealTotalPrice: data[0].staffMealTotalPrice,
      staffMealUnitPrice: data[0].staffMealUnitPrice,
      totalCarFuelCost: data[0].totalCarFuelCost,
      truckUnitPrice: data[0].truckUnitPrice,
      updatedDate: data[0].updatedDate,
      wageTotalCost: data[0].wageTotalCost,
      city: data[0].city,


      

    });

    console.log(data[0].id);
  }

}

