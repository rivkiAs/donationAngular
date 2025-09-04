import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Keren } from 'src/app/Models/Keren';
import { KerenService } from 'src/app/Services/keren.service';

@Component({
  selector: 'app-add-keren-file',
  templateUrl: './add-keren-file.component.html',
  styleUrls: ['./add-keren-file.component.css']
})
export class AddKerenFileComponent {
new_keren:Keren={"catalogNumber": 0, "id":0, "description" : "" ,"percent" :0, "target":0};
catalog:number=0
target:number=0
discribe:string=""
  constructor(private kService:KerenService,private router:Router)
  {

  }

 add(){
    console.log(this.catalog)
    console.log(this.target)
    console.log(this.discribe)
    this.new_keren.catalogNumber=this.catalog
    this.new_keren.target=this.target
    this.new_keren.description=this.discribe
    this.kService.addKeren(this.new_keren).subscribe({})
    console.log("add k!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
    this.router.navigate(['added']);

 } 
}
