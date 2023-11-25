import { NgModule } from "@angular/core";
import { PlannedListComponent } from "./planned/components/list/planned.list.component";
import { CommonModule } from "@angular/common";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from "@angular/material/icon";
import { NgxDatatableModule } from "@swimlane/ngx-datatable";
import { MatTableModule } from '@angular/material/table';
import { ReactiveFormsModule } from "@angular/forms";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatInputModule } from "@angular/material/input";
import { MatButtonModule } from "@angular/material/button";
import { MatNativeDateModule } from "@angular/material/core";
import { RealizedListComponent } from "./realized/components/list/realized.list.component";
import { PlannedFormComponent } from "./planned/components/form/planned.form.component";
@NgModule({
  imports: [
    CommonModule,
    //MatDialogModule,
    MatFormFieldModule,
    MatCardModule,
    MatIconModule,
    NgxDatatableModule,
    MatTableModule,
    ReactiveFormsModule,
    MatDatepickerModule,
    MatInputModule,
    MatButtonModule,
    MatNativeDateModule,
  ],
 
  declarations: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent
  ],
  exports: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent
    
  ]
})
export class SharedModule { }
