import { NgModule } from "@angular/core";
import { CommonModule, DatePipe } from "@angular/common";
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
import { PlannedRealizedComparisonComponent } from "./components/list/plannedrealizedcomparison.list.component";
import { MatListModule } from '@angular/material/list';






@NgModule({
  providers: [DatePipe],
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
    MatListModule,


    // ...
  ],
  declarations: [
  
  
    PlannedRealizedComparisonComponent


  ],
  exports: [
    
   
    PlannedRealizedComparisonComponent


  ]
})
export class PlannedRealizedComparisonModule { }
