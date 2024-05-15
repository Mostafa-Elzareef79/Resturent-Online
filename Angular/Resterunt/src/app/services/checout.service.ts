import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment';

@Injectable({
  providedIn: 'root'
})
export class ChecoutService {
  url=environment.baseUrl;

  constructor(private http:HttpClient) { }
  addOrder(all:any): Observable<any> {

    return this.http.post<any>(`${this.url}/checkout`,all);
  }
  }

