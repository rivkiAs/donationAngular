import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Donor } from 'src/app/Models/Donor';
import { Keren } from 'src/app/Models/Keren';
import { DonorService } from 'src/app/Services/donor.service';

@Component({
  selector: 'app-add-donor',
  templateUrl: './add-donor.component.html',
  styleUrls: ['./add-donor.component.css']
})
export class AddDonorComponent {
    first:string="";
    last:string="";
    tz:string="";
    phone:string="";
    email:string="";
    city:string="";

   new_don:Donor={"tz":"","phoneMumber":"" ,"lastName":"","firstName":"","id":0,"email":"",cities:{"cityName":"","id":0}}
  
   constructor(private donService:DonorService,private router:Router)
   {
 
   }
   add(){
    this.new_don.firstName=this.first;
    this.new_don.lastName=this.last;
    this.new_don.cities.cityName=this.city;
    this.new_don.email=this.email;
    this.new_don.phoneMumber=this.phone;
    this.donService.add(this.new_don).subscribe({})
    alert("המשתמש נוסף בהצלחה");
    this.router.navigate(["add-donation"]);
   }
   

 
}

 





