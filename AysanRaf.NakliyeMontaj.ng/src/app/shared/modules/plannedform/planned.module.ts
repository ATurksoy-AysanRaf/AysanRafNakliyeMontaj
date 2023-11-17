import { NgModule, OnInit } from "@angular/core";
import { PlannedListComponent } from "./components/list/planned.list.component";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { MatIconModule } from "@angular/material/icon";
import { MatNativeDateModule } from "@angular/material/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

@NgModule({
  imports: [
    CommonModule,
    MatIconModule,
    FormsModule,
    ReactiveFormsModule,
    MatNativeDateModule,

   ],
  declarations: [PlannedListComponent],
  exports: [PlannedListComponent]

})
export class PlannedModule  {

}
