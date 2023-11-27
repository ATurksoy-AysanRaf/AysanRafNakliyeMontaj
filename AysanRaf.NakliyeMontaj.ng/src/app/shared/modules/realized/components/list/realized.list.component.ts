import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from "@angular/core";
import { DatatableComponent } from "@swimlane/ngx-datatable";
import { MatTableModule } from '@angular/material/table';
import { MatDialog } from "@angular/material/dialog";
import { RealizedFormComponent } from "../form/realized.form.components";

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
  hmm: number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  { position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H', hmm: 10 },
  { position: 2, name: 'Helium', weight: 4.0026, symbol: 'He', hmm: 10 },
  { position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li', hmm: 10 },
  { position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be', hmm: 10 },
  { position: 5, name: 'Boron', weight: 10.811, symbol: 'B', hmm: 10 },
  { position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C', hmm: 10 },
  { position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N', hmm: 10 },
  { position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O', hmm: 10 },
  { position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F', hmm: 10 },
  { position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne', hmm: 10 },
];

/**
 * @title Basic use of `<table mat-table>`
 */

@Component({

  selector: 'aysanraf-realized-list',
  templateUrl: './realized.list.component.html',
  styleUrls: ['./realized.list.component.scss']

})

export class RealizedListComponent implements OnInit {
  @ViewChild(DatatableComponent)
  table!: DatatableComponent;


  editRow(row: any) {
    // Burada seçilen satırı düzenlemek için gerekli işlemleri yapabilirsiniz.
    console.log('uu', row.name);
  }





  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol', 'hmm'];
  dataSource = ELEMENT_DATA;
  clickedRows = new Set<PeriodicElement>();



  @Input() showFilter: boolean = true;

  @Input() showCreateButton: boolean = false;
  @Output() createButtonClickedEvent = new EventEmitter();

  @Input() showSearchButton: boolean = true;
  @Output() searchButtonClickedEvent = new EventEmitter();

  @Input() showExpenseTypeName: boolean = true;
  @Input() expenseTypeColumnFlexSize: number = 2;

  @Input() showTaskTypeName: boolean = false;

  @Input() showCurrency: boolean = false;
  @Input() showIntegrationCode: boolean = false;
  @Input() showBillParty: boolean = false;
  @Input() showDescription: boolean = false;
  @Input() showBillNo: boolean = false;

  @Input() showSalesOrderNo: boolean = false;
  @Input() showSalesOrderTitle: boolean = false;
  @Input() showCustomer: boolean = false;
  @Input() showShipmentWayBillNo: boolean = false;

  @Input() showCreatedDate: boolean = false;

  @Input() rowCountPerPage: number = 20;
  @Input() selectionModelType: string = 'single'; // 'multiClick'
  @Input() loadDataFromService: boolean = true;


  constructor(private dialog: MatDialog) {


  }
  openDialog() {
    this.dialog.open(RealizedFormComponent, {
      width: '4000px', // Genişlik
      height: '3000px', // Yükseklik
    });
  }






  ngOnInit(): void {

  }

}
