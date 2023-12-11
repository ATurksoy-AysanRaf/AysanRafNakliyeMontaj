import { NgModule } from "@angular/core";

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
import { RealizedListComponent } from "./components/list/realized.list.component";
import { AlertDialogComponent } from "../planned/components/error/planned.error.component";
import { RealizedFormComponent } from "./components/form/realized.form.components";






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
    RealizedListComponent,
    RealizedListComponent,
    RealizedFormComponent,
    AlertDialogComponent,


  ],
  exports: [
    RealizedListComponent,
    RealizedListComponent,
    RealizedFormComponent,
    AlertDialogComponent,


  ]
})
export class RealizedModule { }
