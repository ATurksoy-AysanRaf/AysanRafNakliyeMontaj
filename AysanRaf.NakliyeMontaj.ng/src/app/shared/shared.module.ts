import { NgModule } from "@angular/core";
import { PlannedListComponent } from "./planned/components/list/planned.list.component";
import { CommonModule } from "@angular/common";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from "@angular/material/icon";
import { NgxDatatableModule } from "@swimlane/ngx-datatable";
import { MatTableModule } from '@angular/material/table';
import { ReactiveFormsModule } from "@angular/forms";
@NgModule({
  imports: [
    CommonModule,
    //MatDialogModule,
    MatFormFieldModule,
    MatCardModule,
    MatIconModule,
    NgxDatatableModule,
    MatTableModule,
    ReactiveFormsModule
  ],
 
  declarations: [
    PlannedListComponent
  ],
  exports: [
    PlannedListComponent
  ]
})
export class SharedModule { }
