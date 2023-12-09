import { NgModule } from "@angular/core";

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
import { PlannedListComponent } from "./modules/planned/components/list/planned.list.component";
import { RealizedListComponent } from "./modules/realized/components/list/realized.list.component";
import { PlannedFormComponent } from "./modules/planned/components/form/planned.form.component";
import { RealizedFormComponent } from "./modules/realized/components/form/realized.form.components";
import { ComparisonModule } from "./modules/plannedrealizedcomparison/plannedrealizedcomparison.module";
import { ComparisonListComponent } from "./modules/plannedrealizedcomparison/components/list/plannedrealizedcomparison.list.component";

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
    PlannedFormComponent,
    RealizedFormComponent,
   ComparisonListComponent,
  ],
  exports: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent,
    RealizedFormComponent,
    ComparisonListComponent,
    
  ]
})
export class SharedModule { }
