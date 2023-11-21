import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material/icon';
import { ShippingInstallationModule } from './shippingInstallation/shippingInstallation.module';
import { HttpClientModule } from '@angular/common/http'; // HttpClientModule'ı içe aktarın


import { FormsModule } from '@angular/forms';
import { ShippinInstallationPlannedofFormComponent } from './shippingInstallation/plannedofForm/list/list.component';



//import { MatButtonModule } from '@angular/material';
@NgModule({
  declarations: [
    AppComponent,
    


  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,

    HttpClientModule, // HttpClientModule'ı içe aktarın
    
    MatIconModule,
    ShippingInstallationModule,
    FormsModule,

  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
