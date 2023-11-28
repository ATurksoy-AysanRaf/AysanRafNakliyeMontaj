// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RealizedService {
  private apiUrl = 'https://localhost:7203'; // API'nizin gerçek URL'sini buraya ekleyin

  constructor(private http: HttpClient) { }

  getAllData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/RealizedForms/List`);
  }

  createData(data: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/api/RealizedOfferForm`, data);
  }

  updateData(id: number, data: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/api/RealizedOfferForm/${id}`, data);
  }

  deleteData(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/api/RealizedOfferForm/${id}`);
  }
}









