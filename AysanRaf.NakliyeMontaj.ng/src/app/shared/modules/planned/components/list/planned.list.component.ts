import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from "@angular/core";
import { DatatableComponent } from "@swimlane/ngx-datatable";
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { PlannedService } from "../../services/planned.service";
import { MatDialog } from "@angular/material/dialog";

import { PlannedFormComponent } from "../form/planned.form.component";

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

@Component({

  selector: 'aysanraf-planned-list',
  templateUrl: './planned.list.component.html',
  styleUrls: ['./planned.list.component.scss']

})

export class PlannedListComponent implements OnInit {
  @ViewChild(DatatableComponent)
  table!: DatatableComponent;
  items: any[] = [];

  dataSource: MatTableDataSource<any>;

  displayedColumns: string[] = ['SalesOfferNumber', 'CustomerName', 'City', 'CreatedDate', 'UpdatedDate'];
  
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


  constructor(private dialog: MatDialog, private apiService: PlannedService) {

    this.dataSource = new MatTableDataSource<any>();
  }
  openDialog() {
    this.dialog.open(PlannedFormComponent, {
      width: '4000px', // Genişlik
      height: '3000px', // Yükseklik
    });
  }






  ngOnInit() {
    this.apiService.getListData().subscribe(data => {
      this.items = data;
      // MatTableDataSource'a veriyi ata
      this.dataSource.data = this.items;
    });





  }


}
