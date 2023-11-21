import { NgModule } from "@angular/core";

import { ShippinInstallationPlannedofFormComponent } from "./plannedofForm/list/list.component";
import { SharedModule } from "../shared/shared.module";
//import { PlannedModule } from "../shared/modules/plannedform/planned.module";


@NgModule({
  imports: [
    SharedModule
    ],
  declarations: [
    ShippinInstallationPlannedofFormComponent,
    
  ],
  exports: [
    ShippinInstallationPlannedofFormComponent
  ],
  providers: []
})

export class ShippingInstallationModule {

}
