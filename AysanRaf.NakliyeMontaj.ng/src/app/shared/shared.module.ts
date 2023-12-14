import { NgModule } from "@angular/core";

import { CommonModule, DatePipe } from "@angular/common";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from "@angular/material/icon";
import { NgxDatatableModule } from "@swimlane/ngx-datatable";
import { MatTableModule } from '@angular/material/table';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatInputModule } from "@angular/material/input";
import { MatButtonModule } from "@angular/material/button";
import { MatNativeDateModule } from "@angular/material/core";
import { PlannedListComponent } from "./modules/planned/components/list/planned.list.component";
import { RealizedListComponent } from "./modules/realized/components/list/realized.list.component";
import { PlannedFormComponent } from "./modules/planned/components/form/planned.form.component";
import { RealizedFormComponent } from "./modules/realized/components/form/realized.form.components";

import { MatListModule } from '@angular/material/list';
import { PlannedRealizedComparisonComponent } from "./modules/plannedrealizedComparison/components/list/plannedrealizedcomparison.list.component";


@NgModule({
  providers: [DatePipe],
  imports: [
    CommonModule,
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
    FormsModule,
    MatListModule
  ],
 
  declarations: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent,
    RealizedFormComponent,
    PlannedRealizedComparisonComponent
  ],
  exports: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent,
    RealizedFormComponent,
    PlannedRealizedComparisonComponent
    
  ]
})
export class SharedModule { }
