// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PlannedService {
  private apiUrl = ' http://localhost:5115https://localhost:7203'; // Örnek bir API URL'si

  constructor(private http: HttpClient) { }

  // Örnek bir GET isteği
  getData(): Observable<any> {
    return this.http.get(`${this.apiUrl}/posts`);
  }

  // Örnek bir POST isteği
  postData(data: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/posts`, data);
  }
}
