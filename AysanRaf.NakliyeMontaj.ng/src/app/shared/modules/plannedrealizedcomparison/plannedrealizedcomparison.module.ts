import { NgModule } from "@angular/core";
import { ComparisonListComponent } from "./components/list/plannedrealizedcomparison.list.component";
import { MatButtonModule } from "@angular/material/button";
import { MatInputModule } from "@angular/material/input";
import { MatTableModule } from "@angular/material/table";
import { NgxDatatableModule } from "@swimlane/ngx-datatable";
import { MatCardModule } from "@angular/material/card";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatNativeDateModule } from "@angular/material/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MatIconModule } from "@angular/material/icon";
import { CommonModule } from "@angular/common";

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
    ComparisonListComponent
  ],
  exports: [

    ComparisonListComponent
  ]
})
export class ComparisonModule { }
