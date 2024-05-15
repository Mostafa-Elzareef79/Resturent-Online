import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {
 url=environment.baseUrl;
  constructor(private http:HttpClient) { }
  getitems(id:number): Observable<any[]> {
    return this.http.get<any[]>(`${this.url}/item/${id}`);
  }
}
