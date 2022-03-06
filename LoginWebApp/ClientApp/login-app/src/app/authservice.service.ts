import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { baseUrl } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthserviceService {

  constructor(private http: HttpClient) { }
  login(data: any): Observable<any> {
    console.log(data);
    return this.http.post(`${baseUrl}authenticate`, data);
  }
}
