import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Donation } from '../Models/Donation';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class DonationService {

  url = 'https://localhost:7180/api/Donation';
  constructor(private http: HttpClient) { }

  getDonations(): Observable<Donation[]> {
    return this.http.get<Donation[]>(this.url)
  }
  addKeren(donation: Donation): Observable<Donation> {
    console.log("תרומה להוספה",donation)
    return this.http.post<Donation>(this.url, donation)
  }

}
