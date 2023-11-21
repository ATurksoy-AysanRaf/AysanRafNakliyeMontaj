import { NgModule } from "@angular/core";
import { PlannedListComponent } from "./components/list/planned.list.component";
import { CommonModule } from "@angular/common";
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from "@angular/material/icon";
import { MatNativeDateModule } from "@angular/material/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MatCardModule } from '@angular/material/card';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MatTableModule } from "@angular/material/table";
@NgModule({
  imports: [
    CommonModule,
    MatIconModule,
    FormsModule,
    ReactiveFormsModule,
    MatNativeDateModule,
    MatFormFieldModule,
    MatCardModule,
    NgxDatatableModule,
    MatTableModule,
    
    // ...
  ],
  declarations: [
    PlannedListComponent
  ],
  exports: [
    PlannedListComponent
  ]
})
export class PlannedModule { }
