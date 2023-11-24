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
  constructor(private dataService: PlannedService) {


  }
  ngOnInit(): void {
   
  }
}
