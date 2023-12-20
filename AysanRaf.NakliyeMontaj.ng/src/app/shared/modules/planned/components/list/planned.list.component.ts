import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from "@angular/core";
import { DatatableComponent } from "@swimlane/ngx-datatable";
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { PlannedService } from "../../services/planned.service";
import { MatDialog } from "@angular/material/dialog";
import { PlannedFormComponent } from "../form/planned.form.component";
import { FormBuilder, FormGroup } from '@angular/forms';
import { MAT_DATE_FORMATS, MatDateFormats } from "@angular/material/core";
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



  constructor(private dialog: MatDialog, private apiService: PlannedService, private formBuilder: FormBuilder) {

    this.dataSource = new MatTableDataSource<any>();
  }


  onRowClick(item: any): void {
    this.selectedItem = { ...item }; // Örnek olarak nesne kopyalama kullanabilirsiniz
    // Forma verileri doldurma işlemini burada da çağırabilirsiniz
    this.fillForm();
  }
  fillForm(): void {
    // selectedItem'daki verileri forma doldur
    this.filterForm.patchValue({
      offerNumber: this.selectedItem.salesOfferNumber,
      customer: this.selectedItem.customerName,
      city: this.selectedItem.customerCity,
      // Diğer alanlar
    });
  }

  openAddDialog() {

    this.dialog.open(PlannedFormComponent, {

      width: '4000px', // Genişlik
      height: '3000px', // Yükseklik
    });
  }
  openEditDialog(dataArray: any[], rowIndex: number): number {
    const ids: number[] = [];
    const clickedRowData = dataArray[rowIndex];

    for (const data of dataArray) {
      const id = data.id;
      ids.push(id);
    }
    this.apiService.setSelectedRowData(ids[rowIndex]);
    this.dialog.open(PlannedFormComponent, {
      width: '4000px',
      height: '3000px',
      data: { ids: ids, clickedRowData: clickedRowData, rowIndex: rowIndex },
    });


    // console.log(ids[rowIndex]);

    return ids[rowIndex];
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
    const startDate = this.filterForm.get('startDate').value;
    const endDate = this.filterForm.get('endDate').value;

    // ApiService içindeki bir metod ile veri filtreleme işlemini gerçekleştir
    this.apiService.getListData().subscribe(
      (data: any[]) => {
        // Gelen veriyi listeye ekle
        this.dataList.splice(0, this.dataList.length);
        this.dataList = [...this.dataList, ...data];

        //// Tüm uyan verileri bul
        const matchedItems = this.dataList.filter(dataItem =>
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
        } else {
          // Eşleşen veri bulunamadı
        }

        // Kullanıcıya tüm eşleşen verileri göster
        this.dataSource.data = this.filteredDataList;
      },
      (error) => {
        console.error('Error fetching data:', error);
      }
    );

    this.apiService.getListData().subscribe(data => {
      if (this.filteredDataList.length > 0) {
        // Eğer filteredDataList doluysa, onu kullan
        this.dataSource.data = this.filteredDataList
          .filter(item => this.isWithinLastMonth(item.createdDate));

        console.log("burası okey");
        console.log(this.dataSource.data);
        this.filteredDataList.splice(0, this.filteredDataList.length);
      } else {
        this.filteredDataList.splice(0, this.filteredDataList.length);

       // Eğer filteredDataList boşsa, items'ı kullan
        this.items = data;
        console.log(history);
        this.dataSource.data = this.items
          .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());

        if (history.toString() == "onemon") {
          this.dataSource.data = this.items
            .filter(item => this.isWithinLastMonth(item.createdDate))
            .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
        } else if (history.toString() == "thremon") {
          this.dataSource.data = this.items
            .filter(item => this.isWithinThreMonth(item.createdDate))
            .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
        } else if (history.toString() == "sixmon") {
          this.dataSource.data = this.items
            .filter(item => this.isWithinSixMonth(item.createdDate))
            .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
        } else if (history.toString() == "oneyear") {
          this.dataSource.data = this.items
            .filter(item => this.isWithinLastYear(item.createdDate))
            .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
        } else {
          // Diğer durumlar
        }

        console.log("burası nnokey", this.filteredDataList);
      }
    });
  }





}
  //applyFilters(): void {
  //  // ... Diğer kodlar ...

  //  this.apiService.getListData().subscribe(data => {
  //    if (this.filteredDataList.length > 0) {
  //      // Eğer filteredDataList doluysa, onu kullan
  //      this.dataSource.data = this.filteredDataList
  //        .filter(item => this.isWithinLastMonth(item.createdDate))
  //        .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());

  //      console.log("burası okey");
  //      console.log(this.dataSource.data);
  //      this.filteredDataList.splice(0, this.filteredDataList.length);
  //    } else {
  //      this.filteredDataList.splice(0, this.filteredDataList.length);

  //      // Eğer filteredDataList boşsa, items'ı kullan
  //      this.items = data;
  //      console.log(history);
  //      this.dataSource.data = this.items
  //        .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());

  //      if (history.toString() == "onemon") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinLastMonth(item.createdDate))
  //          .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
  //      } else if (history.toString() == "thremon") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinThreMonth(item.createdDate))
  //          .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
  //      } else if (history.toString() == "sixmon") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinSixMonth(item.createdDate))
  //          .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
  //      } else if (history.toString() == "oneyear") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinLastYear(item.createdDate))
  //          .sort((a, b) => new Date(a.createdDate).getTime() - new Date(b.createdDate).getTime());
  //      } else {
  //        // Diğer durumlar
  //      }

  //      console.log("burası nnokey", this.filteredDataList);
  //    }
  //  });
  //}


  //applyFilters(): void {


  //  const offerNumber = this.filterForm.get('offerNumber').value;
  //  const customer = this.filterForm.get('customer').value;
  //  const city = this.filterForm.get('city').value;
  //  const history = this.filterForm.get('history').value;
  //  const startDate = this.filterForm.get('startDate').value;
  //  const endDate = this.filterForm.get('endDate').value;

  //  // ApiService içindeki bir metod ile veri filtreleme işlemini gerçekleştir
  //  this.apiService.getListData().subscribe(
  //    (data: any[]) => {
  //      // Gelen veriyi listeye ekle
  //      this.dataList.splice(0, this.dataList.length);
  //      this.dataList = [...this.dataList, ...data];
  //      // console.log('Data List:', this.dataList);

  //      //// Tüm uyan verileri bul
  //      const matchedItems = this.dataList.filter(dataItem =>
  //        dataItem.salesOfferNumber === offerNumber ||
  //        dataItem.customerName === customer ||
  //        dataItem.customerCity === city
  //      );



  //      if (matchedItems.length > 0) {
  //        // Eşleşen veri bulundu
  //        console.log('Matches found:', matchedItems);
  //        // Burada istediğiniz işlemleri gerçekleştirebilirsiniz


  //        // Sadece listede olmayan öğeleri filteredDataList'e ekle
  //        const newMatches = matchedItems.filter(item => !this.isItemInFilteredList(item));
  //        this.filteredDataList.push(...newMatches);


  //      } else {

  //      }



  //      // Kullanıcıya tüm eşleşen verileri göster
  //      this.dataSource.data = this.filteredDataList;
  //    },
  //    (error) => {
  //      console.error('Error fetching data:', error);
  //    }
  //  );

  //  this.apiService.getListData().subscribe(data => {
  //    if (this.filteredDataList.length > 0) {
  //      // Eğer filteredDataList doluysa, onu kullan
  //      this.dataSource.data = this.filteredDataList
  //        .filter(item => this.isWithinLastMonth(item.createdDate));

  //      console.log("burası okey");
  //      console.log(this.dataSource.data);
  //      this.filteredDataList.splice(0, this.filteredDataList.length);

  //    } else {
  //      this.filteredDataList.splice(0, this.filteredDataList.length);

  //      // Eğer filteredDataList boşsa, items'ı kullan
  //      this.items = data;
  //      console.log(history);
  //      this.dataSource.data = this.items.sort((a, b) => {
  //        // createDate özelliğine göre sıralama yap
  //        return new Date(b.createdDate).getTime() - new Date(a.createdDate).getTime();
  //      });

  //      if (history == "oneMon") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinLastMonth(item.createdDate));
  //      }
  //      else if (history == "threeMon") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinThreMonth(item.createdDate));
  //      }
  //      else if (history == "sixMon") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinSixMonth(item.createdDate));
  //      }
  //      else if (history == "oneYear") {
  //        this.dataSource.data = this.items
  //          .filter(item => this.isWithinLastYear(item.createdDate));
  //      } else {
         
  //      }




  //      console.log("burası nnokey", this.filteredDataList);
  //    }
  //  });


  //}







