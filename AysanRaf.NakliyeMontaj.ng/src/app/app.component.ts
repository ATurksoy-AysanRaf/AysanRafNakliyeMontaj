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
    // GET isteği örneği
    this.dataService.getData().subscribe(
      (data) => {
        console.log('Alınan Veri:', data);
      },
      (error) => {
        console.error('Hata:', error);
      }
    );
    const postData = { title: 'Başlık', body: 'İçerik' };
    this.dataService.postData(postData).subscribe(
      (response) => {
        console.log('İstek Başarılı:', response);
      },
      (error) => {
        console.error('Hata:', error);
      }
    );
  }
}
