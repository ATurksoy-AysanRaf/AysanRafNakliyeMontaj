import { ChangeDetectorRef, Component, Input, OnInit, SimpleChanges, ViewChild } from "@angular/core";

import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { PlannedRealizedConstainService } from "../../services/plannedrealizedComparison.service";
import { MatInput } from "@angular/material/input";
import { DatePipe } from "@angular/common";
import { AlertDialogComponent } from "../error/plannedrealizedComparison.error.component";
import { catchError } from "rxjs";
import { MatDialog } from "@angular/material/dialog";

@Component({
  selector: 'aysanraf-plannedrealizedComparison-list',
  templateUrl: './plannedrealizedComparison.list.component.html',
  styleUrls: ['./plannedrealizedComparison.list.component.scss'],

})


export class PlannedRealizedComparisonComponent implements OnInit {
  @ViewChild(MatInput) inputElement!: MatInput;
  dataSource = new MatTableDataSource<any>();
  displayedColumns: string[] = ['DATANAME', 'DATA1', 'DATA2',];
  salesOfferNumberFilter: string = '';

  constructor(private dialog: MatDialog, private dataService: PlannedRealizedConstainService, private cdr: ChangeDetectorRef, private datePipe: DatePipe) { }
  ngAfterViewInit() {
    console.log('MatInput Element:', this.inputElement);
  }
  ngOnInit() {
    // İlk yükleme işlemleri
    this.loadData();
  }





  openAlertDialog(): void {
    const dialogRef = this.dialog.open(AlertDialogComponent, {
     // data: { title, message },
      width: '600px',

    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
  onSearchClick() {
    const inputValue = this.salesOfferNumberFilter;
    // salesOfferNumberFilter'ı güncelle ve loadData fonksiyonunu çağır


    if (this.salesOfferNumberFilter != null) {
      this.loadData();
    }
    else {
      console.log("dene");
    }

   
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes["salesOfferNumberFilter"] && !changes["salesOfferNumberFilter"].firstChange) {
      this.loadData();
    }
  }
  formatDate(date: Date): string {
    return this.datePipe.transform(date, 'dd.MM.yyyy HH:mm:ss') || '';
  }

  loadData() {
    if (this.salesOfferNumberFilter) {
      this.dataService.getAllDataP().subscribe((data1) => {
        this.dataService.getAllDataR().subscribe((data2) => {
          // Veri kümesini birleştirme ve filtreleme
          const mergedData = this.mergeAndFilterData(data1, data2, this.salesOfferNumberFilter);
         
          if (mergedData.length > 0) {
            // Eşleşen veri bulunduğunda
            this.dataSource.data = mergedData;
            console.log(mergedData);

            // Change detection'ı manuel olarak tetikle
            setTimeout(() => {
              this.cdr.detectChanges();
            });
          } else {
            this.openAlertDialog();
            // Eşleşen veri bulunamadığında
            console.log("eşleşen yok");
          }
        });
      });
    }
  }


  mergeAndFilterData(data1: any[], data2: any[], filterValue: string): any[] {
    const filteredData1 = data1.filter((item) => item.salesOfferNumber === filterValue);
    const filteredData2 = data2.filter((item) => item.salesOfferNumber === filterValue);

    const mergedData: any[] = [];
    const maxLength = Math.max(filteredData1.length, filteredData2.length);

    for (let i = 0; i < maxLength; i++) {
      const rowData: any = {};

      if (i < filteredData1.length) {
        Object.keys(filteredData1[i]).forEach(key => {
          rowData[key + '1'] = filteredData1[i][key];
        });
      }

      if (i < filteredData2.length) {
        Object.keys(filteredData2[i]).forEach(key => {
          rowData[key + '2'] = filteredData2[i][key];
        });
      }

      mergedData.push(rowData);
    }

    return mergedData;
  }
}









//export class PlannedRealizedComparisonComponent implements OnInit {

//  dataSource = new MatTableDataSource<any>();
//  displayedColumns: string[] = ['DATANAME', 'DATA1', 'DATA2', ];
//  salesOfferNumberFilter: string = '';

//  constructor(private dataService: PlannedRealizedConstainService, private cdr: ChangeDetectorRef) { }

//  ngOnInit() {
//    // İlk yükleme işlemleri
//  }

//  onSearchClick() {
//    const inputValue = this.salesOfferNumberFilter;
//    // salesOfferNumberFilter'ı güncelle ve loadData fonksiyonunu çağır
//    this.loadData();
//    console.log(inputValue);
//    console.log("inputValue");

//  }

//  ngOnChanges(changes: SimpleChanges): void {
//    if (changes["salesOfferNumberFilter"] && !changes["salesOfferNumberFilter"].firstChange) {
//      this.loadData();
//    }
//  }


  

//  // ... diğer metotlar

//  loadData() {
//    if (this.salesOfferNumberFilter) {
//      this.dataService.getAllDataP().subscribe((data1) => {
//        this.dataService.getAllDataR().subscribe((data2) => {
//          // Veri kümesini birleştirme ve filtreleme
//          const mergedData = this.mergeAndFilterData(data1, data2, this.salesOfferNumberFilter);

//          if (mergedData.length > 0) {
//            // Eşleşen veri bulunduğunda
//            this.dataSource.data = mergedData;
//            console.log(mergedData);

//            // Change detection'ı manuel olarak tetikle
//            this.cdr.detectChanges();
//          } else {
//            // Eşleşen veri bulunamadığında
//            console.log("eşleşen yok");
//          }
//        });
//      });
//    }
//  }

//  mergeAndFilterData(data1: any[], data2: any[], filterValue: string): any[] {
//    const filteredData1 = data1.filter((item) => item.salesOfferNumber === filterValue);
//    const filteredData2 = data2.filter((item) => item.salesOfferNumber === filterValue);

//    const mergedData: any[] = [];
//    const maxLength = Math.max(filteredData1.length, filteredData2.length);

//    for (let i = 0; i < maxLength; i++) {
//      const rowData: any = {};

//      if (i < filteredData1.length) {
//        Object.keys(filteredData1[i]).forEach(key => {
//          rowData[key + '1'] = filteredData1[i][key];
//        });
//      }

//      if (i < filteredData2.length) {
//        Object.keys(filteredData2[i]).forEach(key => {
//          rowData[key + '2'] = filteredData2[i][key];
//        });
//      }

//      mergedData.push(rowData);
//    }

//    return mergedData;
//  }



//}
