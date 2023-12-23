import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';


@Component({
  selector: 'aysanraf-planned-failed',
  templateUrl: './planned.failed.component.html',
  styleUrls: ['./planned.failed.component.scss']
})
export class AlertDialogComponent3 {

  constructor(@Inject(MAT_DIALOG_DATA) public data: { title: string; message: string }, private dialogRef: MatDialogRef<AlertDialogComponent3>) {
  }

  closeDialog(): void {
    // Dialog kapatma işlemi
    this.dialogRef.close();
  }
}
