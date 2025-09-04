import { Component } from '@angular/core';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-added',
  templateUrl: './added.component.html',
  styleUrls: ['./added.component.css']
})
export class AddedComponent {
  constructor(private router:Router)
  {

  }
  back(){
    this.router.navigate(["manager"]);
  }
}
