import { Component, OnInit } from "@angular/core";
import {  ViewChild } from '@angular/core';
import { MatTable, MatTableModule } from '@angular/material/table';

import { MatDialogRef } from "@angular/material/dialog";


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


  @ViewChild(MatTable)
    table!: MatTable<PeriodicElement>;


  constructor(private dialogRef: MatDialogRef<PlannedFormComponent>) { }

  close() {
    this.dialogRef.close();
  }


    ngOnInit(): void {
        
    }

}
