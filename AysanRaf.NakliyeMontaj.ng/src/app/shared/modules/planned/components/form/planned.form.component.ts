import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import {  ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialogRef } from "@angular/material/dialog";
import { FormBuilder, FormGroup } from "@angular/forms";


export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}



@Component({
  selector: 'aysanraf-planned-form',
  templateUrl: './planned.form.component.html',
  styleUrls: ['./planned.form.component.scss']
})

export class PlannedFormComponent implements OnInit{
  @Input() formData: any; // Giriş olarak alınan veri
  @Output() formSubmitted = new EventEmitter<any>(); // Form gönderildiğinde tetiklenecek olay
  form: FormGroup | undefined;

  @ViewChild(MatTable)
    table!: MatTable<PeriodicElement>;


  constructor(private dialogRef: MatDialogRef<PlannedFormComponent>, private fb: FormBuilder) {

    this.form = this.fb.group({
      // Formunuzdaki alanları buraya ekleyin
      // Örneğin:
      teklifNo: [''],
      musteri: [''],
      // Diğer alanlar...
    });



  }

  close() {
    this.dialogRef.close();
  }


    ngOnInit(): void {
        
    }

}
