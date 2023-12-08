import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialog, MatDialogRef } from "@angular/material/dialog";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { PlannedService } from "../../services/planned.service";
import { DataSource } from "@angular/cdk/collections";
import { AlertDialogComponent } from "../error/planned.error.component";
import { Observable, Subject, catchError, forkJoin, map, of, switchMap, takeUntil } from "rxjs";







@Component({
  selector: 'aysanraf-planned-form',
  templateUrl: './planned.form.component.html',
  styleUrls: ['./planned.form.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})

export class PlannedFormComponent implements OnInit {

  selectedRowData: any;

  PlannedOfferForm!: FormGroup;
  formBuilder: any;
  destroy$: Subject<void> = new Subject();

  constructor(private dialog: MatDialog, private dialogRef: MatDialogRef<PlannedFormComponent>, private fb: FormBuilder, private dataService: PlannedService) {


  }
  //closeWithDelay(): void {
  //  // 5 saniye sonra close fonksiyonunu çağır
  //  setTimeout(() => {
  //    window.location.reload();
  //    this.PlannedOfferForm.reset();
  //    this.dialogRef.close();
  //  }, 2500); // 5000 milisaniye (5 saniye)
  //}

  onCloseButtonClick(): void {
    // this.closeWithDelay();
  }

  close() {
    window.location.reload();
    this.PlannedOfferForm.reset(); // Formu sıfırla
    this.dialogRef.close();

  }



  ngOnInit(): void {

    this.initializeForm();
    /*   this.subscribeToFormChanges();*/


    this.loadData();
    this.dataService.selectedRowData$.subscribe((data) => {
      this.selectedRowData = data;

    });

  }


  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }
  subscribeToFormChanges(): void {
    this.PlannedOfferForm.valueChanges.pipe(
      takeUntil(this.destroy$)
    ).subscribe((newValues) => {
      // Formdaki herhangi bir değişiklikte yapılacak işlemler buraya yazılır
      // Örneğin: numberDays, offerTonnage, dailyTonnage gibi değerlere göre diğer değerleri güncelle
      this.mapApiDataToForm(newValues, this.selectedRowData);
    });
  }

  updateOtherValues(): void {
    // Formdaki ilgili değerlere göre diğer değerleri güncelle
    const formData = this.PlannedOfferForm.getRawValue();
    // Örneğin: formData.numberDays, formData.offerTonnage, formData.dailyTonnage gibi değerlere göre işlemleri yap
    // ...

    // Güncellenen değerleri forma set et
    this.PlannedOfferForm.patchValue({
      // Güncellenen değerlere göre diğer değerleri set et
      // Örneğin: updatedValue1: newValue1, updatedValue2: newValue2, ...
    });
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
      rentedEquipmentDailyCost1: ['0'],
      rentedEquipmentMonthlyCost1: ['0'],
      rentedEquipmentAmount1: ['0'],
      rentedEquipmentTotalCost1: ['0'],


      rentedEquipmentName2: ['---'],
      rentedEquipmentDailyCost2: ['0'],
      rentedEquipmentMonthlyCost2: ['0'],
      rentedEquipmentAmount2: ['0'],
      rentedEquipmentTotalCost2: ['0'],

      rentedEquipmentName3: ['---'],
      rentedEquipmentDailyCost3: ['0'],
      rentedEquipmentMonthlyCost3: ['0'],
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

  findIdBySalesOfferNumber(salesOfferNumber: number): Observable<string | null> {
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



    this.onCloseButtonClick();
  }

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
        console.log('Received Data from API:', data);
        this.mapApiDataToForm(data, this.selectedRowData);
        this.PlannedOfferForm.setValue(data);
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
        numberDays: Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1),



        /*reallyTonnage: matchedData.reallyTonnage,*/
        reallyTonnage: (matchedData.offerTonnage * matchedData.casualtyRate / 100),

        /* wageTotalAmount: matchedData.wageTotalAmount,*/
        wageTotalAmount: (matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage) * matchedData.numberEmployees,

        /* wageTotalCost: matchedData.wageTotalCost,*/
        wageTotalCost: (((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage) * matchedData.numberEmployees) * matchedData.dailyWageCost) + (Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * (matchedData.isgexpertCost + matchedData.fieldEngineerCost)),

        /*rentedEquipmentTotalCost1: matchedData.rentedEquipmentTotalCost1,*/
        rentedEquipmentTotalCost1: (matchedData.rentedEquipmentDailyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1) + (matchedData.rentedEquipmentMonthlyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1),
        /*rentedEquipmentTotalCost2: matchedData.rentedEquipmentTotalCost2,*/
        rentedEquipmentTotalCost2: (matchedData.rentedEquipmentDailyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2) + (matchedData.rentedEquipmentMonthlyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2),
        /*rentedEquipmentTotalCost3: matchedData.rentedEquipmentTotalCost3,*/
        rentedEquipmentTotalCost3: (matchedData.rentedEquipmentDailyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3) + (matchedData.rentedEquipmentMonthlyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3),
        /*rentedEquipmentTotalCost4: matchedData.rentedEquipmentTotalCost4,*/
        rentedEquipmentTotalCost4: (matchedData.rentedEquipmentDailyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4) + (matchedData.rentedEquipmentMonthlyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4),
        /*equipmentSumCost: matchedData.equipmentSumCost,*/
        equipmentSumCost: (matchedData.equipmentShipmentCost)
          + ((matchedData.rentedEquipmentDailyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4) + (matchedData.rentedEquipmentMonthlyCost4 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount4)
            + (matchedData.rentedEquipmentDailyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3) + (matchedData.rentedEquipmentMonthlyCost3 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount3)
            + (matchedData.rentedEquipmentDailyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2) + (matchedData.rentedEquipmentMonthlyCost2 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount2)
            + (matchedData.rentedEquipmentDailyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1) + (matchedData.rentedEquipmentMonthlyCost1 * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1) * matchedData.rentedEquipmentAmount1)),

        /*accommodationTotalPrice: matchedData.accommodationTotalPrice,*/
        accommodationTotalPrice: matchedData.accommodationUnitPrice * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1),
        /*  staffMealTotalPrice: matchedData.staffMealTotalPrice,*/
        staffMealTotalPrice: matchedData.staffMealUnitPrice * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1),
        /*installationTotalCost: matchedData.installationTotalCost,*/
        installationTotalCost: ((matchedData.accommodationUnitPrice + matchedData.staffMealUnitPrice) * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1)) + matchedData.fieldEngineerCost,
        /* installationTotalCostCurrency: matchedData.installationTotalCostCurrency,*/
        installationTotalCostCurrency: (matchedData.exchangeRate * ((matchedData.accommodationUnitPrice + matchedData.staffMealUnitPrice) * Math.max((matchedData.offerTonnage * matchedData.casualtyRate / 100) / (matchedData.numberEmployees * matchedData.dailyTonnage), 1)) + matchedData.fieldEngineerCost),
        /*shippingTotalCost: matchedData.shippingTotalCost,*/
        shippingTotalCost: matchedData.truckUnitPrice * matchedData.numberTrucksUsed,
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

    const numberEmployeesControl = this.PlannedOfferForm.get('numberEmployees');
    const offerTonnageControl = this.PlannedOfferForm.get('offerTonnage');
    const casualtyRateControl = this.PlannedOfferForm.get('casualtyRate');
    const dailyTonnageControl = this.PlannedOfferForm.get('dailyTonnage');
    const numberDaysControl = this.PlannedOfferForm.get('numberDays');
    const ExchangeRateControl = this.PlannedOfferForm.get('exchangeRate');
    const reallyTonnageControl = this.PlannedOfferForm.get('reallyTonnage');
    const fieldEngineerCostControl = this.PlannedOfferForm.get('fieldEngineerCost');
    const dailyWageCostControl = this.PlannedOfferForm.get('dailyWageCost');
    const wageTotalAmountControl = this.PlannedOfferForm.get('wageTotalAmount');
    const isgexpertCostControl = this.PlannedOfferForm.get('isgexpertCost');
    const wageTotalCostControl = this.PlannedOfferForm.get('wageTotalCost');
    const rentedEquipmentName1Control = this.PlannedOfferForm.get('rentedEquipmentName1');
    const rentedEquipmentName2Control = this.PlannedOfferForm.get('rentedEquipmentName2');
    const rentedEquipmentName3Control = this.PlannedOfferForm.get('rentedEquipmentName3');
    const rentedEquipmentName4Control = this.PlannedOfferForm.get('rentedEquipmentName4');
    const rentedEquipmentDailyCost1Control = this.PlannedOfferForm.get('rentedEquipmentDailyCost1');
    const rentedEquipmentDailyCost2Control = this.PlannedOfferForm.get('rentedEquipmentDailyCost2');
    const rentedEquipmentDailyCost3Control = this.PlannedOfferForm.get('rentedEquipmentDailyCost3');
    const rentedEquipmentDailyCost4Control = this.PlannedOfferForm.get('rentedEquipmentDailyCost4');
    const rentedEquipmentMonthlyCost1Control = this.PlannedOfferForm.get('rentedEquipmentMonthlyCost1');
    const rentedEquipmentMonthlyCost2Control = this.PlannedOfferForm.get('rentedEquipmentMonthlyCost2');
    const rentedEquipmentMonthlyCost3Control = this.PlannedOfferForm.get('rentedEquipmentMonthlyCost3');
    const rentedEquipmentMonthlyCost4Control = this.PlannedOfferForm.get('rentedEquipmentMonthlyCost4');
    const rentedEquipmentAmount1Control = this.PlannedOfferForm.get('rentedEquipmentAmount1');
    const rentedEquipmentAmount2Control = this.PlannedOfferForm.get('rentedEquipmentAmount2');
    const rentedEquipmentAmount3Control = this.PlannedOfferForm.get('rentedEquipmentAmount3');
    const rentedEquipmentAmount4Control = this.PlannedOfferForm.get('rentedEquipmentAmount4');
    const rentedEquipmentTotalCost1Control = this.PlannedOfferForm.get('rentedEquipmentTotalCost1');
    const rentedEquipmentTotalCost2Control = this.PlannedOfferForm.get('rentedEquipmentTotalCost2');
    const rentedEquipmentTotalCost3Control = this.PlannedOfferForm.get('rentedEquipmentTotalCost3');
    const rentedEquipmentTotalCost4Control = this.PlannedOfferForm.get('rentedEquipmentTotalCost4');
    const equipmentShipmentCostControl = this.PlannedOfferForm.get('equipmentShipmentCost');
    const equipmentSumCostControl = this.PlannedOfferForm.get('equipmentSumCost');
    const accommodationUnitPriceControl = this.PlannedOfferForm.get('accommodationUnitPrice');
    const accommodationTotalPriceControl = this.PlannedOfferForm.get('accommodationTotalPrice');
    const staffMealUnitPriceControl = this.PlannedOfferForm.get('staffMealUnitPrice');
    const staffMealTotalPriceControl = this.PlannedOfferForm.get('staffMealTotalPrice');
    const totalCarFuelCostControl = this.PlannedOfferForm.get('totalCarFuelCost');
    const installationTotalCostControl = this.PlannedOfferForm.get('installationTotalCost');
    const installationTotalCostCurrencyControl = this.PlannedOfferForm.get('installationTotalCostCurrency');
    const numberTrucksUsedControl = this.PlannedOfferForm.get('numberTrucksUsed');
    const truckUnitPriceControl = this.PlannedOfferForm.get('truckUnitPrice');
    const shippingTotalCostControl = this.PlannedOfferForm.get('shippingTotalCost');
    const shippingTotalCostCurrencyControl = this.PlannedOfferForm.get('shippingTotalCostCurrency');

    //numberEmployeesControl && offerTonnageControl && casualtyRateControl && dailyTonnageControl && numberDaysControl && ExchangeRateControl && reallyTonnageControl && accommodationTotalPriceControl &&
    //  fieldEngineerCostControl && dailyWageCostControl && wageTotalAmountControl && isgexpertCostControl && wageTotalCostControl && rentedEquipmentName1Control && rentedEquipmentName2Control &&
    //  rentedEquipmentName3Control && rentedEquipmentName4Control && rentedEquipmentDailyCost1Control && rentedEquipmentDailyCost2Control && rentedEquipmentDailyCost3Control && rentedEquipmentDailyCost4Control && rentedEquipmentMonthlyCost1Control &&
    //  rentedEquipmentMonthlyCost2Control && rentedEquipmentMonthlyCost3Control && rentedEquipmentMonthlyCost4Control && rentedEquipmentAmount1Control && rentedEquipmentAmount2Control && rentedEquipmentAmount3Control &&
    //  rentedEquipmentAmount4Control && equipmentShipmentCostControl && equipmentSumCostControl && accommodationUnitPriceControl && staffMealUnitPriceControl && staffMealTotalPriceControl && totalCarFuelCostControl &&
    //  installationTotalCostControl && installationTotalCostCurrencyControl && numberTrucksUsedControl && truckUnitPriceControl && shippingTotalCostControl && shippingTotalCostCurrencyControl
    //  && rentedEquipmentTotalCost1Control && rentedEquipmentTotalCost2Control && rentedEquipmentTotalCost3Control && rentedEquipmentTotalCost4Control


    if (ExchangeRateControl && shippingTotalCostControl && shippingTotalCostCurrencyControl && installationTotalCostControl && installationTotalCostCurrencyControl) {
      //Döviz değeri değişince 
      ExchangeRateControl.valueChanges.subscribe((value) => {
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
        shippingTotalCostCurrencyControl.setValue(shippingTotalCostControl.value * ExchangeRateControl.value);
      });

    }

    if (offerTonnageControl && reallyTonnageControl && casualtyRateControl && numberDaysControl && dailyTonnageControl && wageTotalAmountControl && numberEmployeesControl && wageTotalCostControl && dailyWageCostControl && totalCarFuelCostControl
      && staffMealTotalPriceControl && isgexpertCostControl && fieldEngineerCostControl && accommodationTotalPriceControl && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && ExchangeRateControl)//Teklif tonajı değişirse
    {
      offerTonnageControl.valueChanges.subscribe((value) => {
        reallyTonnageControl.setValue((offerTonnageControl.value * casualtyRateControl.value / 100));
        numberDaysControl.setValue((reallyTonnageControl.value / dailyTonnageControl.value) / numberEmployeesControl.value);
        wageTotalAmountControl.setValue(Math.ceil(numberDaysControl.value) * numberEmployeesControl.value);
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (casualtyRateControl && reallyTonnageControl && offerTonnageControl && numberDaysControl && wageTotalAmountControl && dailyTonnageControl && numberEmployeesControl && wageTotalCostControl && dailyWageCostControl && fieldEngineerCostControl && isgexpertCostControl && totalCarFuelCostControl && staffMealTotalPriceControl && accommodationTotalPriceControl && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && ExchangeRateControl)//Zayiat Oranı değişirse
    {
      casualtyRateControl.valueChanges.subscribe((value) => {

        reallyTonnageControl.setValue((offerTonnageControl.value * casualtyRateControl.value) / 100);
        numberDaysControl.setValue((reallyTonnageControl.value / dailyTonnageControl.value) / numberEmployeesControl.value);
        wageTotalAmountControl.setValue(Math.ceil(numberDaysControl.value) * numberEmployeesControl.value);
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (dailyTonnageControl && numberDaysControl && reallyTonnageControl && numberEmployeesControl && wageTotalAmountControl && wageTotalCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && dailyWageCostControl && fieldEngineerCostControl && isgexpertCostControl && totalCarFuelCostControl && staffMealTotalPriceControl && accommodationTotalPriceControl && equipmentSumCostControl && ExchangeRateControl) //Günlük Tonaj değişirse
    {
      dailyTonnageControl.valueChanges.subscribe((value) => {

        numberDaysControl.setValue((reallyTonnageControl.value / dailyTonnageControl.value) / numberEmployeesControl.value);
        wageTotalAmountControl.setValue(Math.ceil(numberDaysControl.value) * numberEmployeesControl.value);
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }


    if (fieldEngineerCostControl && wageTotalCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalAmountControl && dailyWageCostControl && equipmentSumCostControl && ExchangeRateControl && accommodationTotalPriceControl && isgexpertCostControl && staffMealTotalPriceControl && numberDaysControl && totalCarFuelCostControl)//Saha Mühendis maliyeti değişirse
    {
      fieldEngineerCostControl.valueChanges.subscribe((value) => {
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (dailyWageCostControl && wageTotalCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalAmountControl && equipmentSumCostControl && fieldEngineerCostControl && ExchangeRateControl && accommodationTotalPriceControl && isgexpertCostControl && staffMealTotalPriceControl && numberDaysControl && totalCarFuelCostControl) //Günlük Yevmiye Tutarı
    {
      dailyWageCostControl.valueChanges.subscribe((value) => {
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      })
    }
    if (numberEmployeesControl && numberDaysControl && wageTotalAmountControl && wageTotalCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && reallyTonnageControl && dailyTonnageControl && dailyWageCostControl && equipmentSumCostControl && ExchangeRateControl && fieldEngineerCostControl && accommodationTotalPriceControl && isgexpertCostControl && staffMealTotalPriceControl && totalCarFuelCostControl)//Çalışan sayısı
    {
      numberEmployeesControl.valueChanges.subscribe((value) => {
        numberDaysControl.setValue((reallyTonnageControl.value / dailyTonnageControl.value) / numberEmployeesControl.value);
        wageTotalAmountControl.setValue(Math.ceil(numberDaysControl.value) * numberEmployeesControl.value);
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }

    if (isgexpertCostControl && wageTotalCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalAmountControl && dailyWageCostControl && equipmentSumCostControl && ExchangeRateControl && fieldEngineerCostControl && accommodationTotalPriceControl && staffMealTotalPriceControl && numberDaysControl && totalCarFuelCostControl) //Isg Uzmanı maliyeti değişirse
    {
      isgexpertCostControl.valueChanges.subscribe((value) => {
        wageTotalCostControl.setValue((wageTotalAmountControl.value * dailyWageCostControl.value) + (((fieldEngineerCostControl.value + isgexpertCostControl.value) * Math.ceil(numberDaysControl.value))));
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentDailyCost1Control && rentedEquipmentTotalCost1Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalCostControl && rentedEquipmentAmount1Control && rentedEquipmentTotalCost2Control && ExchangeRateControl && accommodationTotalPriceControl && rentedEquipmentTotalCost3Control && staffMealTotalPriceControl && numberDaysControl && rentedEquipmentTotalCost4Control && totalCarFuelCostControl && equipmentShipmentCostControl)//EkipmanGünlükMaliyet#1 DEĞİŞİRSE
    {
      rentedEquipmentDailyCost1Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost1Control.setValue(rentedEquipmentDailyCost1Control.value * rentedEquipmentAmount1Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentAmount1Control && rentedEquipmentTotalCost1Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentDailyCost1Control && wageTotalCostControl && rentedEquipmentTotalCost2Control && ExchangeRateControl && accommodationTotalPriceControl && rentedEquipmentTotalCost3Control && staffMealTotalPriceControl && equipmentShipmentCostControl && numberDaysControl && totalCarFuelCostControl) //EkipmanAdet#1 DEĞİŞİRSE
    {
      rentedEquipmentAmount1Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost1Control.setValue(rentedEquipmentDailyCost1Control.value * rentedEquipmentAmount1Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost1Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentDailyCost2Control && rentedEquipmentTotalCost2Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentTotalCost1Control && wageTotalCostControl && rentedEquipmentAmount2Control && ExchangeRateControl && accommodationTotalPriceControl &&
      numberDaysControl && rentedEquipmentTotalCost3Control && staffMealTotalPriceControl && rentedEquipmentTotalCost4Control && totalCarFuelCostControl && equipmentShipmentCostControl)//EkipmanGünlükMaliyet#2 DEĞİŞİRSE
    {
      rentedEquipmentDailyCost2Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost2Control.setValue(rentedEquipmentDailyCost2Control.value * rentedEquipmentAmount2Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
  
      
        if (rentedEquipmentAmount2Control && rentedEquipmentTotalCost2Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalCostControl && rentedEquipmentTotalCost1Control &&
          rentedEquipmentDailyCost2Control && ExchangeRateControl && accommodationTotalPriceControl && rentedEquipmentTotalCost3Control && numberDaysControl && staffMealTotalPriceControl && rentedEquipmentTotalCost4Control && totalCarFuelCostControl && equipmentShipmentCostControl) //EkipmanAdet#2 DEĞİŞİRSE
    {
      rentedEquipmentAmount2Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost2Control.setValue(rentedEquipmentDailyCost2Control.value * rentedEquipmentAmount2Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentDailyCost3Control && rentedEquipmentTotalCost3Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentTotalCost1Control && wageTotalCostControl && rentedEquipmentTotalCost2Control && rentedEquipmentAmount3Control &&
      numberDaysControl && accommodationTotalPriceControl && ExchangeRateControl && staffMealTotalPriceControl && rentedEquipmentTotalCost4Control && totalCarFuelCostControl && equipmentShipmentCostControl)//EkipmanGünlükMaliyet#3 DEĞİŞİRSE
    {
      rentedEquipmentDailyCost3Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost3Control.setValue(rentedEquipmentDailyCost3Control.value * rentedEquipmentAmount3Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentAmount3Control && rentedEquipmentTotalCost3Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentDailyCost3Control && rentedEquipmentTotalCost1Control && rentedEquipmentTotalCost2Control &&
      wageTotalCostControl && ExchangeRateControl && accommodationTotalPriceControl && numberDaysControl && staffMealTotalPriceControl && rentedEquipmentTotalCost4Control && totalCarFuelCostControl && equipmentShipmentCostControl )//EkipmanAdet#3 DEĞİŞİRSE
    {
      rentedEquipmentAmount3Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost3Control.setValue(rentedEquipmentDailyCost3Control.value * rentedEquipmentAmount3Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentDailyCost4Control && rentedEquipmentTotalCost4Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentTotalCost1Control && wageTotalCostControl &&
      rentedEquipmentAmount4Control && rentedEquipmentTotalCost2Control && ExchangeRateControl && accommodationTotalPriceControl && rentedEquipmentTotalCost3Control && numberDaysControl && staffMealTotalPriceControl && totalCarFuelCostControl && equipmentShipmentCostControl ) //EkipmanGünlükMaliyet#4 DEĞİŞİRSE
    {
      rentedEquipmentDailyCost4Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost4Control.setValue(rentedEquipmentDailyCost4Control.value * rentedEquipmentAmount4Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (rentedEquipmentAmount4Control && rentedEquipmentTotalCost4Control && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentDailyCost4Control && rentedEquipmentTotalCost1Control &&
      wageTotalCostControl && rentedEquipmentTotalCost2Control && ExchangeRateControl && numberDaysControl && accommodationTotalPriceControl && rentedEquipmentTotalCost3Control && staffMealTotalPriceControl && totalCarFuelCostControl && equipmentShipmentCostControl )//EkipmanAdet#4 DEĞİŞİRSE
    {
      rentedEquipmentAmount4Control.valueChanges.subscribe((value) => {
        rentedEquipmentTotalCost4Control.setValue(rentedEquipmentDailyCost4Control.value * rentedEquipmentAmount4Control.value * numberDaysControl.value);
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (equipmentShipmentCostControl && equipmentSumCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && rentedEquipmentTotalCost1Control && wageTotalCostControl && rentedEquipmentTotalCost2Control && accommodationTotalPriceControl &&
      rentedEquipmentTotalCost3Control && ExchangeRateControl && staffMealTotalPriceControl && rentedEquipmentTotalCost4Control && totalCarFuelCostControl ) {
      equipmentShipmentCostControl.valueChanges.subscribe((value) => {
        equipmentSumCostControl.setValue(rentedEquipmentTotalCost1Control.value + rentedEquipmentTotalCost2Control.value + rentedEquipmentTotalCost3Control.value + rentedEquipmentTotalCost4Control.value + equipmentShipmentCostControl.value)
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (accommodationUnitPriceControl && accommodationTotalPriceControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalCostControl && numberDaysControl && equipmentSumCostControl && ExchangeRateControl && staffMealTotalPriceControl && totalCarFuelCostControl ) {
      accommodationUnitPriceControl.valueChanges.subscribe((value) => {
        accommodationTotalPriceControl.setValue(accommodationTotalPriceControl.value * numberDaysControl.value);
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (staffMealUnitPriceControl && staffMealTotalPriceControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalCostControl && numberDaysControl && equipmentSumCostControl && accommodationTotalPriceControl && ExchangeRateControl && totalCarFuelCostControl ) {
      staffMealUnitPriceControl.valueChanges.subscribe((value) => {
        staffMealTotalPriceControl.setValue(staffMealUnitPriceControl.value * numberDaysControl.value);
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }


    if (totalCarFuelCostControl && installationTotalCostControl && installationTotalCostCurrencyControl && wageTotalCostControl && equipmentSumCostControl && ExchangeRateControl && accommodationTotalPriceControl && staffMealTotalPriceControl ) {
      totalCarFuelCostControl.valueChanges.subscribe((value) => {
        installationTotalCostControl.setValue(wageTotalCostControl.value + equipmentSumCostControl.value + accommodationTotalPriceControl.value + staffMealTotalPriceControl.value + totalCarFuelCostControl.value);
        installationTotalCostCurrencyControl.setValue(installationTotalCostControl.value * ExchangeRateControl.value);
      });
    }
    if (numberTrucksUsedControl && shippingTotalCostControl && shippingTotalCostCurrencyControl && truckUnitPriceControl && ExchangeRateControl ) {
      numberTrucksUsedControl.valueChanges.subscribe((value) => {
        shippingTotalCostControl.setValue(numberTrucksUsedControl.value * truckUnitPriceControl.value);
        shippingTotalCostCurrencyControl.setValue(shippingTotalCostControl.value * ExchangeRateControl.value)
      });
    }
    if (truckUnitPriceControl && shippingTotalCostControl && shippingTotalCostCurrencyControl && numberTrucksUsedControl && ExchangeRateControl ) {
      truckUnitPriceControl.valueChanges.subscribe((value) => {
        shippingTotalCostControl.setValue(numberTrucksUsedControl.value * truckUnitPriceControl.value);
        shippingTotalCostCurrencyControl.setValue(shippingTotalCostControl.value * ExchangeRateControl.value)
      });
    }


  }
}




