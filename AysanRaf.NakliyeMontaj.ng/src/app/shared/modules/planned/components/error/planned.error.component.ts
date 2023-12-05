import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';


@Component({
  selector: 'aysanraf-planned-error',
  templateUrl: './planned.error.component.html',
  styleUrls: ['./planned.error.component.scss']
})
export class AlertDialogComponent {
 
  constructor(@Inject(MAT_DIALOG_DATA) public data: { title: string; message: string } , private dialogRef: MatDialogRef<AlertDialogComponent>) {
}

  closeDialog(): void {
    // Dialog kapatma işlemi
    this.dialogRef.close();
  }
}
