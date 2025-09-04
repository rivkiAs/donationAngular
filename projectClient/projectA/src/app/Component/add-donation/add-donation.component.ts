import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Donation } from 'src/app/Models/Donation';
import { DonationType } from 'src/app/Models/DonationType';
import { Donor } from 'src/app/Models/Donor';
import { DonationService } from 'src/app/Services/donation.service';

@Component({
  selector: 'app-add-donation',
  templateUrl: './add-donation.component.html',
  styleUrls: ['./add-donation.component.css']
})
export class AddDonationComponent {
  new_don: Donation = { "amountPerBeat":0,"donationType":{"id":0,"nameType":""},"id":0,"numberOfBeats":0,
 "keren":{"catalogNumber": 0, "id":0, "description" : "" ,"percent" :0, "target":0},
  "donor":{"tz":"","phoneMumber":"" ,"lastName":"","firstName":"","id":0,"email":"",cities:{"cityName":"","id":0}}};
  donorId: number = 0
  typeId: number = 0
  kerenId: number = 0
  beat: number = 0
  sum: number = 0

  constructor(private dService: DonationService, private router: Router) {

  }
  add(){
    this.new_don.amountPerBeat=this.beat
    this.new_don.donationType.id=this.typeId
    this.new_don.donor.id=this.donorId
    this.new_don.keren.id=this.kerenId
    this.new_don.amountPerBeat=this.sum


 
    this.dService.addKeren(this.new_don).subscribe({})
    alert('התרומה נוספה בהצלחה ')
    this.router.navigate([""]);
  }

}
