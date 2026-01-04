import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Keren } from '../Models/Keren';
@Injectable({
  providedIn: 'root'
})
export class KerenService {
  
  
  url='https://super-cannoli-8c7615.netlify.app';
  constructor(private http:HttpClient) { 
  }
  getKerens():Observable<Keren[]>
    {
       return this.http.get<Keren[]>(this.url)
    }
    addKeren(keren:Keren):Observable<Keren>
    {
      console.log("a",keren)
      debugger
         return this.http.post<Keren>(this.url,keren)      
    }
   
    deleteKeren(id:number):Observable<Keren>
    {   
       console.log("idkeren",id)
      debugger
      console.log(this.http.delete<Keren>(this.url))
         return  this.http.delete<Keren>(this.url+`/${id}`)
         
    }
  }
