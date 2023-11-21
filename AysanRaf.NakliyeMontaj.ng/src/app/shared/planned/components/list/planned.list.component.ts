import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from "@angular/core";
import { DatatableComponent } from "@swimlane/ngx-datatable";

@Component({

  selector: 'aysanraf-planned-list',
  templateUrl: './planned.list.component.html',
  styleUrls: ['./planned.list.component.scss']

})

export class PlannedListComponent implements OnInit {
  @ViewChild(DatatableComponent)
    table!: DatatableComponent;

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


  constructor() {
  }


  //rows = [
  //  { teklifNo: '123', musteri: 'ABC Ltd.', sehir: 'İstanbul', olusturmaTarihi: '2023-11-21', guncellemeTarihi: '2023-11-22' },
  //  { teklifNo: '456', musteri: 'XYZ Inc.', sehir: 'Ankara', olusturmaTarihi: '2023-11-20', guncellemeTarihi: '2023-11-23' },
  //  // Diğer veriler
  //];
  title = 'table-tutorial';
  rows = [
    {
      name: "mercy", age: 10, town: "Nairobi", country: "kenya"
    },
    {
      name: "Vincent", age: 40, town: "Kampala", country: "Uganda"
    },
    {
      name: "Wesley", age: 41, town: "Cairo", country: "Egypt"
    }
  ]




    ngOnInit(): void {
        throw new Error("Method not implemented.");
    }

}
