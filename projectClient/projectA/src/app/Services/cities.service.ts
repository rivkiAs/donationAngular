import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cities } from '../Models/Cities';

@Injectable({
  providedIn: 'root'
})
export class CitiesService {
url="https://super-cannoli-8c7615.netlify.app"
  constructor(private http:HttpClient) { 
    }
allCities():Observable<Cities[]>
{
return this.http.get<Cities[]>(this.url)
}
  }

