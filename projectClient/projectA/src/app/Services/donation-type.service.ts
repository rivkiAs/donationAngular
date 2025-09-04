import { Injectable } from '@angular/core';
import { DonationType } from '../Models/DonationType';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class DonationTypeService {

  url='https://localhost:7180/api/DonationType';
  constructor(private http:HttpClient) { }

  getDT():Observable<DonationType[]>
    {
       return this.http.get<DonationType[]>(this.url)
    }
}
