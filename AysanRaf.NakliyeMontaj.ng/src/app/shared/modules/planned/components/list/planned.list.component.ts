import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from "@angular/core";
import { DatatableComponent } from "@swimlane/ngx-datatable";
import { MatTableModule } from '@angular/material/table';
import { PlannedService } from "../../services/planned.service";
import { MatDialog } from "@angular/material/dialog";
import { ApiService } from "../../../common/web.api.test.service";
import { PlannedFormComponent } from "../form/planned.form.component";

export interface PeriodicElement {
  SalesOfferNumber: number;
  RevisionNumber: string;
  CustomerName: string;
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



  displayedColumns: string[] = ['SalesOfferNumber', 'RevisionNumber', 'CustomerName', 'CreatedDate', 'UpdatedDate'];
  dataSource: any;
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


  constructor(private dialog: MatDialog, private apiService: ApiService) {


  }
  openDialog() {
    this.dialog.open(PlannedFormComponent, {
      width: '4000px', // Genişlik
      height: '3000px', // Yükseklik
    });
  }






  ngOnInit() {
    this.apiService.getAllData().subscribe(data => {
      this.items = data;
    });





  }
}
