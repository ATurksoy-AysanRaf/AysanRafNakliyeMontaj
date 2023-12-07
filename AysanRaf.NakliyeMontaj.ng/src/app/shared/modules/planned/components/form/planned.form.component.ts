import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialog, MatDialogRef } from "@angular/material/dialog";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { PlannedService } from "../../services/planned.service";
import { DataSource } from "@angular/cdk/collections";
import { AlertDialogComponent } from "../error/planned.error.component";
import { Observable, catchError, map, of, switchMap } from "rxjs";







@Component({
  selector: 'aysanraf-planned-form',
  templateUrl: './planned.form.component.html',
  styleUrls: ['./planned.form.component.scss']
})

export class PlannedFormComponent implements OnInit {

  selectedRowData: any;

  PlannedOfferForm!: FormGroup;


  constructor(private dialog: MatDialog, private dialogRef: MatDialogRef<PlannedFormComponent>, private fb: FormBuilder, private dataService: PlannedService) {
 

  }
  closeWithDelay(): void {
    // 5 saniye sonra close fonksiyonunu çağır
    setTimeout(() => {
      window.location.reload();
      this.PlannedOfferForm.reset();
      this.dialogRef.close();
    }, 2500); // 5000 milisaniye (5 saniye)
  }

  onCloseButtonClick(): void {
    this.closeWithDelay();
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
      customerCity: [''],
      accommodationTotalPrice: ['0'],
      accommodationUnitPrice: ['0'],
      casualtyRate: ['96'],
      createdDate: [''],
      customerId: [''],
      customerName: [''],
      dailyTonnage: [''],
      dailyWageAmount: ['0'],
      dailyWageCost: ['0'],
      equipmentShipmentCost: [''],
      equipmentSumCost: [''],
      exchangeRate: ['1'],
      fieldEngineerCost: ['0'],
      installationTotalCost: [''],
      installationTotalCostCurrency: [''],
      isgexpertCost: ['0'],
      numberDays: ['0'],
      numberEmployees: [''],
      numberTrucksUsed: [''],
      offerTonnage: [''],
      reallyTonnage: ['0'],
      wageTotalAmount: ['0'],

     
      rentedEquipmentName1: ['---'],
      rentedEquipmentDailyCost1:['0'],
      rentedEquipmentMonthlyCost1: ['0'],
      rentedEquipmentAmount1: ['0'],
      rentedEquipmentTotalCost1:['0'],
     

      rentedEquipmentName2: ['---'],
      rentedEquipmentDailyCost2: ['0'],
      rentedEquipmentMonthlyCost2: ['0'],
      rentedEquipmentAmount2: ['0'],
      rentedEquipmentTotalCost2: ['0'],

      rentedEquipmentName3: ['---'],
      rentedEquipmentDailyCost3: ['0'],
      rentedEquipmentMonthlyCost3:['0'],
      rentedEquipmentAmount3: ['0'],
      rentedEquipmentTotalCost3: ['0'],

      rentedEquipmentName4: ['---'],
      rentedEquipmentDailyCost4: ['0'],
      rentedEquipmentMonthlyCost4: ['0'],
      rentedEquipmentAmount4: ['0'],
      rentedEquipmentTotalCost4: ['0'],






      salesOfferNumber: [''],
      shippingTotalCost: [''],
      shippingTotalCostCurrency: [''],
      staffMealTotalPrice: [''],
      staffMealUnitPrice: [''],
      totalCarFuelCost: [''],
      truckUnitPrice: [''],
      updatedDate: [''],
      wageTotalCost: ['0'],

    });
  }

  checkData(): Observable<number> {
    const formSalesOfferNumber = this.PlannedOfferForm.get('salesOfferNumber')?.value;

    // Verileri servisten al ve formu doldur
    return this.dataService.getAllData().pipe(
      map((data: any[]) => {
        const isSalesOfferNumberExists = data.some((item: any) => item.salesOfferNumber === formSalesOfferNumber);

        if (isSalesOfferNumberExists) {
          this.openAlertDialog('Hata', `SalesOfferNumber "${formSalesOfferNumber}" zaten var.`);
          return 1; // Eğer kayıt varsa 1 döndür
        } else {
          // SalesOfferNumber değeri benzersiz, formu doldurabilirsiniz
          this.mapApiDataToForm(data, this.selectedRowData);
          return 0; // Eğer kayıt yoksa 0 döndür
        }
      }),
      catchError((error) => {
        console.error('Veri alınamadı:', error);
        return of(-1); // Hata durumunda -1 döndür
      })
    );
  }

  findIdBySalesOfferNumber(salesOfferNumber: number): Observable<string|null > {
    return this.dataService.getAllData().pipe(
      switchMap(data => {
        const matchedData = data.find((item: { salesOfferNumber: number; id: string; }) => item.salesOfferNumber === salesOfferNumber);

        if (matchedData) {
          return of(String(matchedData.id));
        } else {
          console.log("id yok");
          return of(null); // veya başka bir değer döndürebilirsiniz
        }
      }),
      catchError(error => {
        console.error('Error fetching data:', error);
        return of(null); // veya başka bir değer döndürebilirsiniz
      })
    );
  }

  openAlertDialog(title: string, message: string): void {
    const dialogRef = this.dialog.open(AlertDialogComponent, {
      data: { title, message },
      width: '600px',

    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  onSubmit(): void {
    // FormGroup'u düz JavaScript nesnesine dönüştür
    const formData = this.PlannedOfferForm.getRawValue();

    // CreatedDate ve UpdatedDate özelliklerini UTC'ye dönüştür
    formData.CreatedDate = this.convertToUtc(formData.CreatedDate);
    formData.UpdatedDate = this.convertToUtc(formData.UpdatedDate);

    // checkData fonksiyonunu çağır ve dönüş değerine göre işlem yap
    this.checkData().subscribe(
      (result) => {
        if (result === 0) {
          // Kayıt yok, createData fonksiyonunu çağır
          this.dataService.createData(formData).subscribe(
            (response) => {
              console.log('Entity added successfully:', response);
            },
            (error) => {
              console.error('Error adding entity:', error);
            }
          );
        }

      }
    );
    this.onCloseButtonClick();
  }

  onEdit(): void {
    // FormGroup'u düz JavaScript nesnesine dönüştür
    const formData = this.PlannedOfferForm.getRawValue();
    // CreatedDate ve UpdatedDate özelliklerini UTC'ye dönüştür
    formData.CreatedDate = this.convertToUtc(formData.CreatedDate);
    formData.UpdatedDate = this.convertToUtc(formData.UpdatedDate);

    this.findIdBySalesOfferNumber(formData.salesOfferNumber).subscribe(
      result => {
        if (result !== null) {
          console.log('ID found:', result);
       
    
   


  
    const ids = this.findIdBySalesOfferNumber(formData.salesOfferNumber).toString();


    console.log(formData.salesOfferNumber);
    console.log(ids);
    // Kayıt var, updateData fonksiyonunu çağır

    this.dataService.getAllData()

    this.dataService.updateData(result, formData).subscribe(
      (response) => {
        console.log('Entity updated successfully:', response);
      },
      (error) => {
        console.error('Error updating entity:', error);
      }
          );

        } else {
          console.log('ID not found');
        }
      }
     );

  

    this.onCloseButtonClick();
  }

  onDelete(): void {
    const formData = this.PlannedOfferForm.getRawValue();

    this.findIdBySalesOfferNumber(formData.salesOfferNumber).subscribe(
      result => {
        if (result !== null) {
          console.log('ID found:', result);






          const ids = this.findIdBySalesOfferNumber(formData.salesOfferNumber).toString();


          console.log(formData.salesOfferNumber);
          console.log(ids);
          // Kayıt var, updateData fonksiyonunu çağır

          this.dataService.getAllData()

          this.dataService.deleteData(result).subscribe(
            (response) => {
              console.log('Entity updated successfully:', response);
            },
            (error) => {
              console.error('Error updating entity:', error);
            }
          );

        } else {
          console.log('ID not found');
        }
      }
    );



    this.onCloseButtonClick(); }

  private areDatesEqual(date1: Date, date2: Date): boolean {
    // İki tarihin eşit olup olmadığını kontrol et
    return date1 && date2 && date1.getTime() === date2.getTime();
  }

  private convertToUtc(date: Date): Date {
    return date ? new Date(date.toISOString()) : new Date();
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

    const matchedData = data.find(item => item.id === id);

    if (matchedData) {
      let formattedCreatedDate: string;

      formattedCreatedDate = matchedData.createdDate.substring(0, 10);


      this.PlannedOfferForm.patchValue({
        // numberDays: (matchedData.numberDays),
        // Eğer numberDays 1'den küçükse, 1 olarak ayarla
        numberDays : Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1),



        /*reallyTonnage: matchedData.reallyTonnage,*/
        reallyTonnage: (matchedData.offerTonnage * matchedData.casualtyRate / 100),
      
       /* wageTotalAmount: matchedData.wageTotalAmount,*/
        wageTotalAmount: (matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage) * matchedData.numberEmployees,

       /* wageTotalCost: matchedData.wageTotalCost,*/
        wageTotalCost: (((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage) * matchedData.numberEmployees) * matchedData.dailyWageCost) + (Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) *(matchedData.isgexpertCost + matchedData.fieldEngineerCost)),

        /*rentedEquipmentTotalCost1: matchedData.rentedEquipmentTotalCost1,*/
        rentedEquipmentTotalCost1: (matchedData.rentedEquipmentDailyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1) + (matchedData.rentedEquipmentMonthlyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1),
        /*rentedEquipmentTotalCost2: matchedData.rentedEquipmentTotalCost2,*/
        rentedEquipmentTotalCost2: (matchedData.rentedEquipmentDailyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2) + (matchedData.rentedEquipmentMonthlyCost2* Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2),
        /*rentedEquipmentTotalCost3: matchedData.rentedEquipmentTotalCost3,*/
        rentedEquipmentTotalCost3: (matchedData.rentedEquipmentDailyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3) + (matchedData.rentedEquipmentMonthlyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3),
        /*rentedEquipmentTotalCost4: matchedData.rentedEquipmentTotalCost4,*/
        rentedEquipmentTotalCost4: (matchedData.rentedEquipmentDailyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4) + (matchedData.rentedEquipmentMonthlyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4),
        /*equipmentSumCost: matchedData.equipmentSumCost,*/
        equipmentSumCost:( matchedData.equipmentShipmentCost)
         +( (matchedData.rentedEquipmentDailyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4) + (matchedData.rentedEquipmentMonthlyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4)
         +  (matchedData.rentedEquipmentDailyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3) + (matchedData.rentedEquipmentMonthlyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3)
         +  (matchedData.rentedEquipmentDailyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2) + (matchedData.rentedEquipmentMonthlyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2)
         +  (matchedData.rentedEquipmentDailyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1) + (matchedData.rentedEquipmentMonthlyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1)),

        /*accommodationTotalPrice: matchedData.accommodationTotalPrice,*/
        accommodationTotalPrice: matchedData.accommodationUnitPrice * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1),
      /*  staffMealTotalPrice: matchedData.staffMealTotalPrice,*/
        staffMealTotalPrice: matchedData.staffMealUnitPrice * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1),
        /*installationTotalCost: matchedData.installationTotalCost,*/
        installationTotalCost: ((matchedData.accommodationUnitPrice + matchedData.staffMealUnitPrice) * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1)) + matchedData.fieldEngineerCost,
       /* installationTotalCostCurrency: matchedData.installationTotalCostCurrency,*/
        installationTotalCostCurrency: (matchedData.exchangeRate *((matchedData.accommodationUnitPrice + matchedData.staffMealUnitPrice) * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1)) + matchedData.fieldEngineerCost),
        /*shippingTotalCost: matchedData.shippingTotalCost,*/
        shippingTotalCost: matchedData.truckUnitPrice * matchedData.numberTrucksUsed ,
        /*shippingTotalCostCurrency: matchedData.shippingTotalCostCurrency,*/
        shippingTotalCostCurrency: (matchedData.truckUnitPrice * matchedData.numberTrucksUsed) * matchedData.exchangeRate,




       
       
       

        staffMealUnitPrice: matchedData.staffMealUnitPrice,
        accommodationUnitPrice: matchedData.accommodationUnitPrice,
        salesOfferNumber: matchedData.salesOfferNumber,
       
        casualtyRate: matchedData.casualtyRate,
        createdDate: formattedCreatedDate,
        customerId: matchedData.customerId,
        customerName: matchedData.customerName.toUpperCase(),
        dailyTonnage: matchedData.dailyTonnage,
        dailyWageAmount: matchedData.dailyWageAmount,
        dailyWageCost: matchedData.dailyWageCost,
        equipmentShipmentCost: matchedData.equipmentShipmentCost,
        
       
        exchangeRate: matchedData.exchangeRate,
        fieldEngineerCost: matchedData.fieldEngineerCost,
       
        isgexpertCost: matchedData.isgexpertCost,
       

        



        numberEmployees: matchedData.numberEmployees,
        offerTonnage: matchedData.offerTonnage,
      
        //rentedEquipmentId: matchedData.rentedEquipmentId,
        //rentedEquipmentName: matchedData.rentedEquipmentName,

        
       
        totalCarFuelCost: matchedData.totalCarFuelCost,
        truckUnitPrice: matchedData.truckUnitPrice,
        updatedDate: matchedData.updatedDate,
       
        customerCity: matchedData.customerCity.toUpperCase(),
        numberTrucksUsed: matchedData.numberTrucksUsed,
        // Diğer alanları buraya ekleyin
        // ...
        rentedEquipmentName1: matchedData.rentedEquipmentName1,
        rentedEquipmentDailyCost1: matchedData.rentedEquipmentDailyCost1,
        rentedEquipmentMonthlyCost1: matchedData.rentedEquipmentMonthlyCost1,
        rentedEquipmentAmount1: matchedData.rentedEquipmentAmount1,
       


        rentedEquipmentName2: matchedData.rentedEquipmentName2,
        rentedEquipmentDailyCost2: matchedData.rentedEquipmentDailyCost2,
        rentedEquipmentMonthlyCost2: matchedData.rentedEquipmentMonthlyCost2,
        rentedEquipmentAmount2: matchedData.rentedEquipmentAmount2,
        

        rentedEquipmentName3: matchedData.rentedEquipmentName3,
        rentedEquipmentDailyCost3: matchedData.rentedEquipmentDailyCost3,
        rentedEquipmentMonthlyCost3: matchedData.rentedEquipmentMonthlyCost3,
        rentedEquipmentAmount3: matchedData.rentedEquipmentAmount3,
       

        rentedEquipmentName4: matchedData.rentedEquipmentName4,
        rentedEquipmentDailyCost4: matchedData.rentedEquipmentDailyCost4,
        rentedEquipmentMonthlyCost4: matchedData.rentedEquipmentMonthlyCost4,
        rentedEquipmentAmount4: matchedData.rentedEquipmentAmount4,
       





      });
    } else {
      console.error(`Veri bulunamadı: ID ${id}`);




      // Formdan alınan verileri kullan
      const formData = this.PlannedOfferForm.getRawValue();
      let formattedCreatedDate: string;
      let formattedUpdatedDate: string;

      if (formData.createdDate) {
        formattedCreatedDate = formData.createdDate.substring(0, 10);
        formattedUpdatedDate = formData.updatedDate.substring(0, 10);
      } else {
        formattedCreatedDate = new Date().toISOString().substring(0, 10);
        formattedUpdatedDate = new Date().toISOString().substring(0, 10);
      }

      this.PlannedOfferForm.patchValue({
        salesOfferNumber: formData.salesOfferNumber,
        accommodationTotalPrice: formData.accommodationTotalPrice,
        accommodationUnitPrice: formData.accommodationUnitPrice,
        casualtyRate: formData.casualtyRate,
        createdDate: formattedCreatedDate,

        customerId: formData.customerId,
        customerName: formData.customerName,
        dailyTonnage: formData.dailyTonnage,
        dailyWageAmount: formData.dailyWageAmount,
        dailyWageCost: formData.dailyWageCost,
        equipmentShipmentCost: formData.equipmentShipmentCost,
        equipmentSumtCost: typeof formData.equipmentSumtCost === 'number' ? formData.equipmentSumtCost : null,
        exchangeRate: formData.exchangeRate,
        fieldEngineerCost: formData.fieldEngineerCost,
        installationTotalCost: formData.installationTotalCost,
        installationTotalCostCurrency: formData.installationTotalCostCurrency,
        isgexpertCost: formData.isgexpertCost,
        numberDays: formData.numberDays,
        numberEmployees: formData.numberEmployees,
        offerTonnage: formData.offerTonnage,
        reallyTonnage: formData.reallyTonnage,
        //rentedEquipmentId: formData.rentedEquipmentId,
        //rentedEquipmentName: formData.rentedEquipmentName,
        shippingTotalCost: formData.shippingTotalCost,
        shippingTotalCostCurrency: formData.shippingTotalCostCurrency,
        staffMealTotalPrice: formData.staffMealTotalPrice,
        staffMealUnitPrice: formData.staffMealUnitPrice,
        totalCarFuelCost: formData.totalCarFuelCost,
        truckUnitPrice: formData.truckUnitPrice,
        updatedDate: formattedUpdatedDate,
        wageTotalCost: formData.wageTotalCost,
        customerCity: formData.customerCity,
        numberTrucksUsed: formData.numberTrucksUsed,
        // Diğer alanları buraya ekleyin
        // ...
      });
    }


  }


}

