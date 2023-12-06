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




  constructor(private dialog: MatDialog, private apiService: PlannedService, private formBuilder: FormBuilder) {

    this.dataSource = new MatTableDataSource<any>();
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
  applyFilters(): void {
    const offerNumber = this.filterForm.get('offerNumber').value;
    const customer = this.filterForm.get('customer').value;
    const city = this.filterForm.get('city').value;
    const history = this.filterForm.get('history').value;
    const startDate = this.filterForm.get('startDate').value;
    const endDate = this.filterForm.get('endDate').value;

    // ApiService içindeki bir metod ile veri filtreleme işlemini gerçekleştir
    this.apiService.getListData().subscribe(
      (data: any[]) => {
        // Gelen veriyi listeye ekle
        this.dataList = [...this.dataList, ...data];
        console.log('Data List:', this.dataList);

        // Tüm uyan verileri bul
        const matchedItems = this.dataList.filter(dataItem =>
          dataItem.salesOfferNumber === offerNumber ||
          dataItem.customerName === customer ||
          dataItem.customerCity === city
        );

        //if (matchedItems.length > 0) {
        //  // Eşleşen veri bulundu
        //  console.log('Matches found:', matchedItems);
        //  // Burada istediğiniz işlemleri gerçekleştirebilirsiniz
        //  console.log("errorrr1");
         
        //  // Eşleşen verileri filteredDataList'e ekle
        //  this.filteredDataList.push(...matchedItems);
      
        //  console.log("burası rererer", this.filteredDataList);
        //} else {
        //  console.log("errorrr2");
        //}
        if (matchedItems.length > 0) {
          // Eşleşen veri bulundu
          console.log('Matches found:', matchedItems);
          // Burada istediğiniz işlemleri gerçekleştirebilirsiniz
          console.log("errorrr1");

          // Sadece listede olmayan öğeleri filteredDataList'e ekle
          const newMatches = matchedItems.filter(item => !this.filteredDataList.some(existingItem => existingItem.id === item.id));
          this.filteredDataList.push(...newMatches);

          console.log("burası rererer", this.filteredDataList);
        } else {
          console.log("errorrr2");
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
        this.dataSource.data = this.filteredDataList;

        console.log("burası okey");
        this.filteredDataList.splice(0, this.filteredDataList.length);

      } else {
        this.filteredDataList.splice(0, this.filteredDataList.length);

        // Eğer filteredDataList boşsa, items'ı kullan
        this.items = data;
        this.dataSource.data = this.items;
        console.log("burası nnokey", this.filteredDataList);
      }
    });
  }
  }


  

