import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { MatDialog } from '@angular/material/dialog';

import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { PlannedService } from './shared/modules/planned/services/planned.service';
import { PlannedFormComponent } from './shared/modules/planned/components/form/planned.form.component';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'AysanRaf.NakliyeMontaj.ng';
  data: any;
  public isButtonClicked1: boolean = false;
  public isButtonClicked2: boolean = false;
  public isButtonClicked3: boolean = false;

  toggleDivContent1() {
    this.isButtonClicked1 = !this.isButtonClicked1;
    this.isButtonClicked2 = false;
    this.isButtonClicked3 = false;
  }

  toggleDivContent2() {
    this.isButtonClicked2 = !this.isButtonClicked2;
    this.isButtonClicked1 = false;
    this.isButtonClicked3 = false;
  }

  toggleDivContent3() {
    this.isButtonClicked3 = !this.isButtonClicked3;
    this.isButtonClicked1 = false;
    this.isButtonClicked2 = false;
  }

  constructor(private dataService: PlannedService, private dialog: MatDialog) {


  }
  openDialog() {
    this.dialog.open(PlannedFormComponent);
  }

  ngOnInit(): void {
   
  }
}
