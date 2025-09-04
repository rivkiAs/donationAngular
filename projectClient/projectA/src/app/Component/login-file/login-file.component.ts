import { Component } from '@angular/core';
import { Route, Router } from '@angular/router';
import { Donor } from 'src/app/Models/Donor';
import { DonationService } from 'src/app/Services/donation.service';
import { DonorService } from 'src/app/Services/donor.service';
import 'yup';

@Component({
  selector: 'app-login-file',
  templateUrl: './login-file.component.html',
  styleUrls: ['./login-file.component.css']
})
export class LoginFileComponent {
  disable = true
  pass: string = ''
  ans: number = 2
  constructor(private dService: DonorService, private router: Router) {

  }
  enter() {
    
    console.log(this.pass)
    this.dService.login(this.pass).subscribe(
      a => {
        console.log(a)
        this.ans = a;
        if (this.ans == 0) {
          this.router.navigate(["manager"]);

        }
        else if (this.ans == 1) {
          this.router.navigate(["client"]);
        }
        else {
          this.router.navigate(["not-exists"]);
        }
        this.disable = false
      }
    )
  }
}


