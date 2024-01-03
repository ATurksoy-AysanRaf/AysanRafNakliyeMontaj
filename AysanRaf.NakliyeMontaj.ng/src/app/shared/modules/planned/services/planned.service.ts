// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BehaviorSubject } from 'rxjs';

import * as XLSX from 'xlsx';
@Injectable({
  providedIn: 'root',
})
export class PlannedService {
  private apiUrl = "http://192.168.1.32:8020"; // API'nizin gerçek URL'sini buraya ekleyin

  private selectedRowData = new BehaviorSubject<any>(null);
  selectedRowData$ = this.selectedRowData.asObservable();

  setSelectedRowData(data: any): void {
    this.selectedRowData.next(data);
  }

  constructor(private http: HttpClient) {

  

  }

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

  updateData(id: string, data: any): Observable<any> {

    return this.http.put<any>(`${this.apiUrl}/api/PlannedOfferForm/${id}`, data);
  }
  getExportExcell(Id: string): Observable<Blob> {
    return this.http.get(`${this.apiUrl}/api/planned-export-to-excel/${Id}`, { responseType: 'blob' });
  }

  deleteData(id: string): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/api/PlannedOfferForm/${id}`);
  }
}







 

