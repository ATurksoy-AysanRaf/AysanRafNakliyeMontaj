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
import { MatDatepickerModule } from '@angular/material/datepicker'; // MatDatepickerModule eklenmiş
import { MatInputModule } from "@angular/material/input";
import { MatButtonModule } from "@angular/material/button";
import { RealizedListComponent } from "../realized/components/list/realized.list.component";
import { PlannedFormComponent } from "./components/form/planned.form.component";
import { AlertDialogComponent } from "./components/error/planned.error.component";
import { UppercaseOnlyDirective } from "./components/form/Directives";




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
    MatDatepickerModule,
    MatInputModule,
    MatButtonModule,
   
  
    
    // ...
  ],
  declarations: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent,
    AlertDialogComponent,
    UppercaseOnlyDirective,
  ],
  exports: [
    PlannedListComponent,
    RealizedListComponent,
    PlannedFormComponent,
    AlertDialogComponent,
    UppercaseOnlyDirective,
  ]
})
export class PlannedModule { }
