// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RealizedService {
 /* private apiUrl = 'http://192.168.1.32:8020'; // API'nizin gerçek URL'sini buraya ekleyin*/
  private apiUrl = 'https://localhost:7203'; // API'nizin gerçek URL'sini buraya ekleyin

  private selectedRowData = new BehaviorSubject<any>(null);
  selectedRowData$ = this.selectedRowData.asObservable();


  setSelectedRowData(data: any): void {
    this.selectedRowData.next(data);
  }


  constructor(private http: HttpClient) { }

  getByIdData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/RealizedOfferForm/{id}`);
  }

  getAllData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/RealizedOfferForm`);
  }
  getListData(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/api/RealizedForms/List`);
  }
  createData(data: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/api/RealizedOfferForm`, data);
  }

  updateData(id: string, data: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/api/RealizedOfferForm/${id}`, data);
  }

  deleteData(id: string): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/api/RealizedOfferForm/${id}`);
  }

  getExportExcell(Id: string): Observable<Blob> {
    return this.http.get(`${this.apiUrl}/api/RealizedExcellExport/realized-export-to-excel/${Id}`, { responseType: 'blob' });
  }


}









