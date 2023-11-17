import { NgModule } from "@angular/core";
//import { PlannedListComponent } from "../shared/modules/plannedform/components/list/planned.list.component";
import { ShippinInstallationPlannedofFormComponent } from "./plannedofForm/list/list.component";
import { PlannedModule } from "../shared/modules/plannedform/planned.module";

@NgModule({
  imports: [
    PlannedModule
    ],
  declarations: [ShippinInstallationPlannedofFormComponent

  ],
  providers: []
})

export class ShippingInstallationModule {

}
