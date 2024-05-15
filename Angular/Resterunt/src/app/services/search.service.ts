import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../environment';


@Injectable({
  providedIn: 'root'
})
export class SearchService {
   url=environment.baseUrl;

  constructor(private http:HttpClient) { 

  }
  getAllcities(): Observable<any[]> {
    return this.http.get<any[]>(`${this.url}/city`);
  }
  getAllRestruntInCity(id:number): Observable<any[]> {
    return this.http.get<any[]>(`${this.url}/Restrunt/${id}`);
  }
  getAllRestrunts(): Observable<any[]> {
    return this.http.get<any[]>(`${this.url}/Restrunt`);
  }
 
}
