import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Donor } from '../Models/Donor';
@Injectable({
  providedIn: 'root'
})
export class DonorService {

  url='https://localhost:7180/api/Donor';
  constructor(private http:HttpClient) { 
  }
  login(tz:string):Observable<number>
    {
       return this.http.get<number>(this.url+'/check/'+tz)
    }
    add(d:Donor):Observable<number>
    {
      console.log("d",d)
       return this.http.post<number>(this.url,d)
    }


    getDonor():Observable<Donor[]>
    {
       return this.http.get<Donor[]>(this.url)
    }
}
