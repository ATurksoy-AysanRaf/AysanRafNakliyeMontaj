import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from "@angular/core";
import { DatatableComponent } from "@swimlane/ngx-datatable";
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { PlannedService } from "../../services/planned.service";
import { MatDialog } from "@angular/material/dialog";
import { PlannedFormComponent } from "../form/planned.form.component";
import { FormBuilder, FormGroup } from '@angular/forms';
import { MAT_DATE_FORMATS, MatDateFormats } from "@angular/material/core";
import { map, switchMap } from 'rxjs/operators';
export interface PeriodicElement {
  SalesOfferNumber: number;
  RevisionNumber: string;
  CustomerName: string;
  City: string;
  CreateDate: string;
  UpdatedDate: string;
}
/**
 * @title Basic use of `<table mat-table>`
 */


const MY_DATE_FORMATS: MatDateFormats = {
  parse: {
    dateInput: 'YYYY/MM/DD',
  },
  display: {
    dateInput: 'YYYY/MM/DD',
    monthYearLabel: 'MMM YYYY',
    dateA11yLabel: 'YYYY/MM/DD',
    monthYearA11yLabel: 'MMMM YYYY',
  },
};

@Component({

  selector: 'aysanraf-planned-list',
  templateUrl: './planned.list.component.html',
  styleUrls: ['./planned.list.component.scss'],
  providers: [
    { provide: MAT_DATE_FORMATS, useValue: MY_DATE_FORMATS },
  ],
})

export class PlannedListComponent implements OnInit {
  @ViewChild(DatatableComponent)
  table!: DatatableComponent;
  items: any[] = [];
  filterForm: FormGroup | any;
  dataList: any[] = [];
  dataSource: MatTableDataSource<any>;
  filteredDataList: any[] = [];
  displayedColumns: string[] = ['SalesOfferNumber', 'CustomerName', 'City', 'CreatedDate', 'UpdatedDate'];
  clickedRows = new Set<PeriodicElement>();
  selectedItem: any;
  clickedRowData = new Set<PeriodicElement>();
  constructor(private dialog: MatDialog, private apiService: PlannedService, private formBuilder: FormBuilder) {

    this.dataSource = new MatTableDataSource<any>();
  }

  openAddDialog() {

    this.dialog.open(PlannedFormComponent, {

      width: '4000px', // Genişlik
      height: '3000px', // Yükseklik
    });
  }


  //// openEditDialog fonksiyonu içinde
  //async openEditDialog(dataArray: any[], rowIndex: number): Promise<number> {
  //  const ids: number[] = [];

  //  // ... (Diğer kodlar)

  //  try {
  //    const dialogRef = this.dialog.open(PlannedFormComponent, {
  //      width: '4000px',
  //      height: '3000px',
  //      data: { ids: ids, clickedRowData: this.clickedRowData, rowIndex: rowIndex },
  //    });

  //    dialogRef.afterClosed().subscribe(async result => {
  //      if (result) {
  //        // Kullanıcı bir şeyler seçti ve result içinde tıklanan satırın salesOfferNumber değeri bulunuyor.
  //        const selectedSalesOfferNumber = result.salesOfferNumber;

  //        // salesOfferNumber'a göre veriyi bul
  //        const selectedData = dataArray.find(item => item.salesOfferNumber === selectedSalesOfferNumber);

  //        // Bulunan veriyi kullanarak formu doldur
  //        if (selectedData) {
  //          // Örneğin, bu veriyi bir servise göndererek diğer bileşenle paylaşabilirsiniz.
  //           //this.dataService.setPlannedFormData(selectedData);

  //          // Ya da doğrudan PlannedFormComponent'a bir metod aracılığıyla gönderebilirsiniz.
  //          const plannedFormComponentInstance = dialogRef.componentInstance as PlannedFormComponent;
  //          plannedFormComponentInstance.loadData();
  //        }
  //      }
  //    });

  //    return ids[rowIndex];
  //  } catch (error) {
  //    console.error(error);
  //    throw error;
  //  }
  //}

  async openEditDialog(dataArray: any[], rowIndex: number): Promise<number> {
    const ids: number[] = [];
    const clickedRowData = dataArray[rowIndex];

    for (const data of dataArray) {
      const id = data.id;
      ids.push(id);
    }

    this.apiService.setSelectedRowData(ids[rowIndex]);

    try {
      await this.dialog.open(PlannedFormComponent, {
        width: '4000px',
        height: '3000px',
        data: { ids: ids, clickedRowData: clickedRowData, rowIndex: rowIndex },
      }).afterClosed().toPromise();

      // Dialog başarıyla kapatıldığında ids[rowIndex]'i döndür
      return ids[rowIndex];
    } catch (error) {
      // Hata durumunda ilgili hata yönetimini yap
      console.error(error);
      throw error;
    }
  }
  ngOnInit() {

    this.filterForm = this.formBuilder.group({
      offerNumber: [''],
      customer: [''],
      city: [''],
      history: ['oneMon'], // default value
      startDate: [''],
      endDate: ['']
    });

    this.applyFilters();






  }
  isWithinDateRange(itemDate: string, startDate: Date, endDate: Date): boolean {
    const date = new Date(itemDate);
    return date >= startDate && date <= endDate;
  }
  isWithinLastMonth(dateString: string): boolean {
    const currentDate = new Date();
    const itemDate = new Date(dateString);

    // Son 1 ay içinde mi kontrol et
    return (
      itemDate >= new Date(currentDate.getFullYear(), currentDate.getMonth() - 1, currentDate.getDate())
    );
  }
  isWithinThreMonth(dateString: string): boolean {
    const currentDate = new Date();
    const itemDate = new Date(dateString);

    // Son 3 ay içinde mi kontrol et
    return (
      itemDate >= new Date(currentDate.getFullYear(), currentDate.getMonth() - 3, currentDate.getDate())
    );
  }
  isWithinSixMonth(dateString: string): boolean {
    const currentDate = new Date();
    const itemDate = new Date(dateString);

    // Son 6 ay içinde mi kontrol et
    return (
      itemDate >= new Date(currentDate.getFullYear(), currentDate.getMonth() - 6, currentDate.getDate())
    );
  }
  isWithinLastYear(dateString: string): boolean {
    const currentDate = new Date();
    const itemDate = new Date(dateString);

    // Son 1 yıl içinde mi kontrol et
    return (
      itemDate >= new Date(currentDate.getFullYear() - 1, currentDate.getMonth(), currentDate.getDate())
    );
  }
  isItemInFilteredList(item: any): boolean {
    return this.filteredDataList.some(existingItem => {
      // İki değeri karşılaştırırken tür uyumsuzluğunu önlemek için Number() kullanabilirsiniz
      const existingSalesOfferNumber = Number(existingItem.salesOfferNumber);
      const itemSalesOfferNumber = Number(item.salesOfferNumber);

      return existingSalesOfferNumber === itemSalesOfferNumber;
    });
  }








  applyFilters(): void {
    this.dataList = [];
    const offerNumber = this.filterForm.get('offerNumber').value.toLocaleLowerCase('tr-TR');
    const customer = this.filterForm.get('customer').value.toLocaleLowerCase('tr-TR');
    const city = this.filterForm.get('city').value.toLocaleLowerCase('tr-TR');
    const history = this.filterForm.get('history').value.toLocaleLowerCase('tr-TR');
    // ...
    const startDate = this.filterForm.get('startDate').value;
    const endDate = this.filterForm.get('endDate').value;

    
      // ApiService içindeki bir metod ile veri filtreleme işlemini gerçekleştir

    this.apiService.getListData().subscribe(data => {
    
   /*   if (this.filteredDataList.length > 0) {*/

        ////   Eğer filteredDataList doluysa, onu kullan
        //  this.dataSource.data = this.filteredDataList.filter(item => this.isWithinLastMonth(item.createdDate));
        this.dataSource.data = this.filteredDataList;
        // this.filteredDataList.splice(0, this.filteredDataList.length);

        this.filteredDataList.splice(0, this.filteredDataList.length);

        //   Eğer filteredDataList boşsa, items'ı kullan
        this.items = data;
        console.log(history);
        this.dataSource.data = this.items.sort((b, a) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());

   

    

        if (history.toString() =="oneMon") {
          //    Gelen veriyi listeye ekle
        // this.dataList.splice(0, this.dataList.length);
          this.dataList = [...this.dataList, ...data];
      
          //  Tüm uyan verileri bul
          const matchedItems = this.dataList
            .filter(item => this.isWithinLastMonth(item.createdDate.toString()))
            .filter(dataItem =>
              dataItem.salesOfferNumber.toLocaleLowerCase('tr-TR').includes(offerNumber) &&
              dataItem.customerName.toLocaleLowerCase('tr-TR').includes(customer) &&
              dataItem.customerCity.toLocaleLowerCase('tr-TR').includes(city)
          );

          if (matchedItems.length > 0) {
            //   Eşleşen veri bulundu
            console.log('Matches found:', matchedItems);
            //  Burada istediğiniz işlemleri gerçekleştirebilirsiniz

            //   Sadece listede olmayan öğeleri filteredDataList'e ekle
            const newMatches = matchedItems.filter(item => !this.isItemInFilteredList(item));
            this.filteredDataList.push(...newMatches);

            //   Kullanıcıya tüm eşleşen verileri göster
            this.dataSource.data = this.filteredDataList;
          } else {
            //  Eşleşen veri bulunamadı
            console.log("No matches found.");
          }
        }
        else if (history.toString() == "threemon") {
          //    Gelen veriyi listeye ekle
          this.dataList.splice(0, this.dataList.length);
          this.dataList = [...this.dataList, ...data];
          console.log("3 ay");

          //   Tüm uyan verileri bul
          const matchedItems = this.dataList
            .filter(item => this.isWithinThreMonth(item.createdDate.toString()))
            .filter(dataItem =>
              dataItem.salesOfferNumber.toLocaleLowerCase('tr-TR').includes(offerNumber) &&
              dataItem.customerName.toLocaleLowerCase('tr-TR').includes(customer) &&
              dataItem.customerCity.toLocaleLowerCase('tr-TR').includes(city)
            );

          if (matchedItems.length > 0) {
            // Eşleşen veri bulundu
            console.log('Matches found:', matchedItems);
            // Burada istediğiniz işlemleri gerçekleştirebilirsiniz

            // Sadece listede olmayan öğeleri filteredDataList'e ekle
            const newMatches = matchedItems.filter(item => !this.isItemInFilteredList(item));
            this.filteredDataList.push(...newMatches);

            //  Kullanıcıya tüm eşleşen verileri göster
            this.dataSource.data = this.filteredDataList;
          } else {
            // Eşleşen veri bulunamadı
            console.log("No matches found.");
          }

        }
        else if (history.toString() == "sixmon") {
          // Gelen veriyi listeye ekle
          this.dataList.splice(0, this.dataList.length);
          this.dataList = [...this.dataList, ...data];

          //   Tüm uyan verileri bul
          const matchedItems = this.dataList
            .filter(item => this.isWithinSixMonth(item.createdDate.toString()))
            .filter(dataItem =>
              dataItem.salesOfferNumber.toLocaleLowerCase('tr-TR').includes(offerNumber) &&
              dataItem.customerName.toLocaleLowerCase('tr-TR').includes(customer) &&
              dataItem.customerCity.toLocaleLowerCase('tr-TR').includes(city)
            );

          if (matchedItems.length > 0) {
            //   Eşleşen veri bulundu
            console.log('Matches found:', matchedItems);
            //  Burada istediğiniz işlemleri gerçekleştirebilirsiniz

            //   Sadece listede olmayan öğeleri filteredDataList'e ekle
            const newMatches = matchedItems.filter(item => !this.isItemInFilteredList(item));
            this.filteredDataList.push(...newMatches);

            //   Kullanıcıya tüm eşleşen verileri göster
            this.dataSource.data = this.filteredDataList;
          } else {
            //   Eşleşen veri bulunamadı
            console.log("No matches found.");
          }

        }
        else if (history.toString() == "oneyear") {
          //  Gelen veriyi listeye ekle
          this.dataList.splice(0, this.dataList.length);
          this.dataList = [...this.dataList, ...data];

          //  Tüm uyan verileri bul
          const matchedItems = this.dataList
            .filter(item => this.isWithinLastYear(item.createdDate.toString()))
            .filter(dataItem =>
              dataItem.salesOfferNumber.toLocaleLowerCase('tr-TR').includes(offerNumber) &&
              dataItem.customerName.toLocaleLowerCase('tr-TR').includes(customer) &&
              dataItem.customerCity.toLocaleLowerCase('tr-TR').includes(city)
            );

          if (matchedItems.length > 0) {
            // Eşleşen veri bulundu
            console.log('Matches found:', matchedItems);
            //   Burada istediğiniz işlemleri gerçekleştirebilirsiniz

            //  Sadece listede olmayan öğeleri filteredDataList'e ekle
            const newMatches = matchedItems.filter(item => !this.isItemInFilteredList(item));
            this.filteredDataList.push(...newMatches);

            // Kullanıcıya tüm eşleşen verileri göster
            this.dataSource.data = this.filteredDataList;
          } else {
            //   Eşleşen veri bulunamadı
            console.log("No matches found.");
          }

        }
        else {
          // Gelen veriyi listeye ekle
          this.dataList.splice(0, this.dataList.length);
          this.dataList = [...this.dataList, ...data];

          // Tüm uyan verileri bul
          const matchedItems = this.dataList
            .filter(dataItem =>
              dataItem.salesOfferNumber.toLocaleLowerCase('tr-TR').includes(offerNumber) &&
              dataItem.customerName.toLocaleLowerCase('tr-TR').includes(customer) &&
              dataItem.customerCity.toLocaleLowerCase('tr-TR').includes(city)
            );

          if (matchedItems.length > 0) {
            // Eşleşen veri bulundu
            console.log('Matches found:', matchedItems);
            // Burada istediğiniz işlemleri gerçekleştirebilirsiniz

            // Sadece listede olmayan öğeleri filteredDataList'e ekle
            const newMatches = matchedItems.filter(item => !this.isItemInFilteredList(item));
            this.filteredDataList.push(...newMatches);

            // Kullanıcıya tüm eşleşen verileri göster
            this.dataSource.data = this.filteredDataList;
          } else {
            // Eşleşen veri bulunamadı
            console.log("No matches found.");
          }
        }
      

     
     

     /* } */

      })

    }



  }
   



  


