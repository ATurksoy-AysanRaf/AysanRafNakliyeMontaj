import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialog, MatDialogRef } from "@angular/material/dialog";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { PlannedService } from "../../services/planned.service";
import { DataSource } from "@angular/cdk/collections";






@Component({
  selector: 'aysanraf-planned-form',
  templateUrl: './planned.form.component.html',
  styleUrls: ['./planned.form.component.scss']
})

export class PlannedFormComponent implements OnInit {

  selectedRowData: any;

  PlannedOfferForm!: FormGroup;




  constructor(private dialog: MatDialog ,private dialogRef: MatDialogRef<PlannedFormComponent>, private fb: FormBuilder, private dataService: PlannedService) {


  }
 

  close() {
    window.location.reload();
    this.PlannedOfferForm.reset(); // Formu sıfırla
    this.dialogRef.close();
    
  }


  ngOnInit(): void {

    this.initializeForm();

    this.dataService.selectedRowData$.subscribe((data) => {
      this.selectedRowData = data;

    });
  
    this.loadData();

  }

  initializeForm(): void {
    this.PlannedOfferForm = this.fb.group({
      // Formunuzdaki alanları buraya ekleyin
      customerCity:[''],
      accommodationTotalPrice: [''],
      accommodationUnitPrice: [''],
      casualtyRate: ['0.96'],
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
      //  console.log('Received Data from API:', data);
        this.mapApiDataToForm(data, this.selectedRowData);
      },
      (error) => {
        console.error('Veri alınamadı:', error);
      }
    );

  
  }

  mapApiDataToForm(data: any[], id: number): void {



    if (this.PlannedOfferForm.dirty || this.PlannedOfferForm.touched) {
      this.PlannedOfferForm.reset(); // Formu sıfırla
    }
    /* Formdaki kontrol adlarıyla API'den gelen veriyi eşleştir */

    const matchedData = data.find(item => item.id === id);

    if (matchedData) {

      const formattedCreatedDate = matchedData.createdDate.substring(0, 10);

      this.PlannedOfferForm.patchValue({


        salesOfferNumber: matchedData.salesOfferNumber + "-" + matchedData.revisionNumber,
        accommodationTotalPrice: matchedData.accommodationTotalPrice,
        accommodationUnitPrice: matchedData.accommodationUnitPrice,
        casualtyRate: matchedData.casualtyRate,
        createdDate: formattedCreatedDate,
        customerId: matchedData.customerId,
        customerName: matchedData.customerName,
        dailyTonnage: matchedData.dailyTonnage,
        dailyWageAmount: matchedData.dailyWageAmount,
        dailyWageCost: matchedData.dailyWageCost,
        equipmentShipmentCost: matchedData.equipmentShipmentCost,
        equipmentSumtCost: matchedData.equipmentSumtCost,
        exchangeRate: matchedData.exchangeRate,
        fieldEngineerCost: matchedData.fieldEngineerCost,
        installationTotalCost: matchedData.installationTotalCost,
        installationTotalCostCurrency: matchedData.installationTotalCostCurrency,
        isgexpertCost: matchedData.isgexpertCost,
        numberDays: matchedData.numberDays,
        numberEmployees: matchedData.numberEmployees,
        offerTonnage: matchedData.offerTonnage,
        reallyTonnage: matchedData.reallyTonnage,
        rentedEquipmentId: matchedData.rentedEquipmentId,
        rentedEquipmentName: matchedData.rentedEquipmentName,
        shippingTotalCost: matchedData.shippingTotalCost,
        shippingTotalCostCurrency: matchedData.shippingTotalCostCurrency,
        staffMealTotalPrice: matchedData.staffMealTotalPrice,
        staffMealUnitPrice: matchedData.staffMealUnitPrice,
        totalCarFuelCost: matchedData.totalCarFuelCost,
        truckUnitPrice: matchedData.truckUnitPrice,
        updatedDate: matchedData.updatedDate,
        wageTotalCost: matchedData.wageTotalCost,
        customerCity: matchedData.customerCity,
        // Diğer alanları buraya ekleyin
        // ...


        
      });
    } else {
      console.error(`Veri bulunamadı: ID ${id}`);
      // Hata durumunda isteğe bağlı olarak bir mesaj gösterebilirsiniz
      // this.toastr.error('Veri bulunamadı', 'Hata');
    }
   
  }
  ngOnDestroy(): void {
    // Sayfa ömrü sona erdiğinde formu temizle
    if (this.PlannedOfferForm) {
      this.PlannedOfferForm.reset();
    }
  }

}

