import { NgModule } from "@angular/core";

import { ShippingInstallationPlannedListComponent } from "./plannedofForm/list/list.component";
import { SharedModule } from "../shared/shared.module";
import { ShippingInstallationRealizedListComponent } from "./realizedofForm/list/list.component";
import { PlannedFormCreateComponent } from "./plannedofForm/create/create.component";
import { RealizedFormCreateComponent } from "./realizedofForm/create/create.component";
import { ShippingInstallationComparisonListComponent } from "./plannedrealizedcomparison/list/list.component";
//import { PlannedModule } from "../shared/modules/plannedform/planned.module";


@NgModule({
  imports: [
    SharedModule
    ],
  declarations: [
    ShippingInstallationComparisonListComponent,
    ShippingInstallationPlannedListComponent,
    ShippingInstallationRealizedListComponent,
    PlannedFormCreateComponent,
    RealizedFormCreateComponent,
   
  ],
  exports: [
    ShippingInstallationComparisonListComponent,
    ShippingInstallationPlannedListComponent,
    ShippingInstallationRealizedListComponent,
    PlannedFormCreateComponent,
    RealizedFormCreateComponent,
    
  ],
  providers: []
})

export class ShippingInstallationModule {

}
