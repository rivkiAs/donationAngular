import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Donation } from 'src/app/Models/Donation';
import { DonationType } from 'src/app/Models/DonationType';
import { Donor } from 'src/app/Models/Donor';
import { Keren } from 'src/app/Models/Keren';
import { DonationTypeService } from 'src/app/Services/donation-type.service';
import { DonationService } from 'src/app/Services/donation.service';
import { DonorService } from 'src/app/Services/donor.service';
import { KerenService } from 'src/app/Services/keren.service';

@Component({
  selector: 'app-manager-area',
  templateUrl: './manager-area.component.html',
  styleUrls: ['./manager-area.component.css']
})
export class ManagerAreaComponent {

  id_del: number = 0
  listKeren: Keren[] = []
  listdonors: Donor[] = []
  listTypeDonor: DonationType[] = []
  listDonation: Donation[] = []

  type = "cash"
  kerenshow = false
  donorshow = false
  typedonorshow = false
  donationshow = false

  constructor(private donorService: DonorService, private kService: KerenService, private dtService: DonationTypeService, private dService: DonationService, private router: Router) {
    kService.getKerens().subscribe(a => {
      this.listKeren = a;
      donorService.getDonor().subscribe(a => {
        this.listdonors = a;
        dtService.getDT().subscribe(a => {
          this.listTypeDonor = a;
          dService.getDonations().subscribe(a => {
            this.listDonation = a;
          })
        })
      })
    })

  }
  open4() {
    this.typedonorshow = false
    this.kerenshow = false
    this.donationshow = true
    this.donorshow = false
    console.log(this.listDonation)
  }
  open1() {
    this.typedonorshow = false
    this.kerenshow = true
    this.donationshow = false
    this.donorshow = false
    console.log(this.listKeren)

  }
  open2() {
    this.typedonorshow = false
    this.kerenshow = false
    this.donationshow = false
    this.donorshow = true
    console.log(this.listdonors)

  }
  open3() {
    this.typedonorshow = true
    this.kerenshow = false
    this.donationshow = false
    this.donorshow = false
    console.log(this.listTypeDonor)

  }
  addKeren() {
    this.router.navigate(["add-keren"]);
  }
  delKeren(id: number) {
    this.kService.deleteKeren(id).subscribe({})
  }
  addDonation() {
    this.router.navigate(["add-donation"]);
  }

}
