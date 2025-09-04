import { Component } from '@angular/core';
import { CitiesService } from './Services/cities.service';
import { DonorService } from './Services/donor.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'projectA';
  disable=true
  pass:string=''
  ans:number=2
  
  constructor(private dService:DonorService,private router:Router)
  {

  }
enter()
  {
    console.log(this.pass)
this.dService.login(this.pass).subscribe(
  a=>{
    console.log(a)
    this.ans=a;
    if(this.ans==0)
    {
      this.router.navigate(["manager"]);

    }
    else if(this.ans==1){
      this.router.navigate(["client"]);
    }
    else{
      this.router.navigate(["not-exists"]);
    }
     this.disable=false
  }
)
  }
  }

