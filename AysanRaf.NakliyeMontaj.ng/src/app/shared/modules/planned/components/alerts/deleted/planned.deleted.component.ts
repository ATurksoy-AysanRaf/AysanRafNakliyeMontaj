import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';


@Component({
  selector: 'aysanraf-planned-deleted',
  templateUrl: './planned.deleted.component.html',
  styleUrls: ['./planned.deleted.component.scss']
})
export class AlertDialogComponent4 {

  constructor(@Inject(MAT_DIALOG_DATA) public data: { title: string; message: string }, private dialogRef: MatDialogRef<AlertDialogComponent4>) {
  }

  closeDialog(): void {
    // Dialog kapatma işlemi
    this.dialogRef.close();
  }
}
