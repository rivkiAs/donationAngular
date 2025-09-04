import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NewCompComponent } from './Component/new-comp/new-comp.component';
import { BeginFileComponent } from './Component/begin-file/begin-file.component';
import { DonationsFileComponent } from './Component/donations-file/donations-file.component';
import { LoginFileComponent } from './Component/login-file/login-file.component';
import { KerenListFileComponent } from './Component/keren-list-file/keren-list-file.component';
import { AddKerenFileComponent } from './Component/add-keren-file/add-keren-file.component';
import { EndPageComponent } from './Component/end-page/end-page.component';
import { AddDonorComponent } from './Component/add-donor/add-donor.component';
import {MatTableModule} from '@angular/material/table';


import {HttpClientModule} from '@angular/common/http'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ManagerAreaComponent } from './Component/manager-area/manager-area.component';
import { AddedComponent } from './Component/added/added.component';
import { AddDonationComponent } from './Component/add-donation/add-donation.component';

@NgModule({
  declarations: [
    AppComponent,
    NewCompComponent,
    BeginFileComponent,
    DonationsFileComponent,
    LoginFileComponent,
    KerenListFileComponent,
    AddKerenFileComponent,
    EndPageComponent,
    AddDonorComponent,
    ManagerAreaComponent,
    AddedComponent,
    AddDonationComponent,

    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule,ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
