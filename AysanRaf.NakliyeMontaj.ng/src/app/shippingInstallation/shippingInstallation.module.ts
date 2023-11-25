import { NgModule } from "@angular/core";

import { ShippingInstallationPlannedListComponent } from "./plannedofForm/list/list.component";
import { SharedModule } from "../shared/shared.module";
import { ShippingInstallationRealizedListComponent } from "./realizedofForm/list/list.component";
import { PlannedFormCreateComponent } from "./plannedofForm/create/create.component";
//import { PlannedModule } from "../shared/modules/plannedform/planned.module";


@NgModule({
  imports: [
    SharedModule
    ],
  declarations: [
    ShippingInstallationPlannedListComponent,
    ShippingInstallationRealizedListComponent,
    PlannedFormCreateComponent
    
  ],
  exports: [
    ShippingInstallationPlannedListComponent,
    ShippingInstallationRealizedListComponent,
    PlannedFormCreateComponent
  ],
  providers: []
})

export class ShippingInstallationModule {

}
