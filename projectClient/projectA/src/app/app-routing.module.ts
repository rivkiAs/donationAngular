import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DonationsFileComponent } from './Component/donations-file/donations-file.component';
import { AddDonorComponent } from './Component/add-donor/add-donor.component';
import { ManagerAreaComponent } from './Component/manager-area/manager-area.component';
import { LoginFileComponent } from './Component/login-file/login-file.component';
import { AddKerenFileComponent } from './Component/add-keren-file/add-keren-file.component';
import { AddedComponent } from './Component/added/added.component';
import { AddDonationComponent } from './Component/add-donation/add-donation.component';

const routes: Routes = [
  { path: '', component: LoginFileComponent },
 { path: 'client', component: AddDonationComponent },
  { path: 'add-keren', component: AddKerenFileComponent },
  { path: 'added', component: AddedComponent },
  { path: 'add-donation', component: AddDonationComponent }, 
  { path: 'not-exists', component: AddDonorComponent }, 
  { path: 'manager', component: ManagerAreaComponent
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
