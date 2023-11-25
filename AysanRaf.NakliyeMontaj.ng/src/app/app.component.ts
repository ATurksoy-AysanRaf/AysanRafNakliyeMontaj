import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PlannedService } from './shared/planned/services/planned.service';
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

  constructor(private dataService: PlannedService) {


  }
  ngOnInit(): void {
   
  }
}
