// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PlannedRealizedConstainService {
  private apiUrl = 'https://localhost:7203'; // API'nizin gerçek URL'sini buraya ekleyin

  private selectedRowData = new BehaviorSubject<any>(null);
  selectedRowData$ = this.selectedRowData.asObservable();


  setSelectedRowData(data: any): void {
    this.selectedRowData.next(data);
  }


  constructor(private http: HttpClient) { }

  getByIdDataR(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/RealizedOfferForm/{id}`);
  }

  getAllDataR(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/RealizedOfferForm`);
  }
  getListDataR(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/RealizedForms/List`);
  }
  createDataR(data: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/api/RealizedOfferForm`, data);
  }

  updateDataR(id: string, data: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/api/RealizedOfferForm/${id}`, data);
  }

  deleteDataR(id: string): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/api/RealizedOfferForm/${id}`);
  }
  getByIdDataP(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/PlannedOfferForm/{id}`);
  }
  getAllDataP(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/PlannedOfferForm`);
  }
  getListDataP(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/PlannedOfferForm/PlannedForms/List`);
  }
  createDataP(data: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/api/PlannedOfferForm`, data);
  }

  updateDataP(id: string, data: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/api/PlannedOfferForm/${id}`, data);
  }

  deleteDataP(id: string): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/api/PlannedOfferForm/${id}`);
  }
}


