import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';


@Component({
  selector: 'aysanraf-planned-succes',
  templateUrl: './planned.succeeded.component.html',
  styleUrls: ['./planned.succeeded.component.scss']
})
export class AlertDialogComponent2 {

  constructor(@Inject(MAT_DIALOG_DATA) public data: { title: string; message: string }, private dialogRef: MatDialogRef<AlertDialogComponent2>) {
  }

  closeDialog(): void {
    // Dialog kapatma işlemi
    this.dialogRef.close();
  }
}
