import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material/icon';

import { HttpClientModule } from '@angular/common/http'; // HttpClientModule'ı içe aktarın
import { MatDialogModule } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { ShippingInstallationModule } from './shippingInstallation/shippingInstallation.module';




//import { MatButtonModule } from '@angular/material';
@NgModule({
  declarations: [
    AppComponent,
    


  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    MatButtonModule,
   
    HttpClientModule, // HttpClientModule'ı içe aktarın
    
    MatIconModule,
    ShippingInstallationModule,
    FormsModule,
    MatDialogModule,
    MatButtonModule,
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
