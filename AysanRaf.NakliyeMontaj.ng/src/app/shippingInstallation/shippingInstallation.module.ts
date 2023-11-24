import { NgModule } from "@angular/core";

import { ShippingInstallationPlannedofFormComponent } from "./plannedofForm/list/list.component";
import { SharedModule } from "../shared/shared.module";
//import { PlannedModule } from "../shared/modules/plannedform/planned.module";


@NgModule({
  imports: [
    SharedModule
    ],
  declarations: [
    ShippingInstallationPlannedofFormComponent,
    
  ],
  exports: [
    ShippingInstallationPlannedofFormComponent
  ],
  providers: []
})

export class ShippingInstallationModule {

}
