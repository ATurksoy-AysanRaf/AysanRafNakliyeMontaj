// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PlannedService {
  private apiUrl = 'https://localhost:7203'; // API'nizin gerçek URL'sini buraya ekleyin

  private selectedRowData = new BehaviorSubject<any>(null);
  selectedRowData$ = this.selectedRowData.asObservable();




 



  setSelectedRowData(data: any): void {
    this.selectedRowData.next(data);
  }

  constructor(private http: HttpClient) { }
  getByIdData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/PlannedOfferForm/{id}`);
  }
  getAllData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/PlannedOfferForm`);
  }
  getListData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/PlannedOfferForm/PlannedForms/List`);
  }
  createData(data: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/api/PlannedOfferForm`, data);
  }

  updateData(id: number, data: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/api/PlannedOfferForm/${id}`, data);
  }

  deleteData(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/api/PlannedOfferForm/${id}`);
  }
}







 

