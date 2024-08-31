import { Component, OnInit } from '@angular/core';
import { AppService } from '../Services/app.service';

type person = {
  name: string;
  email: string;
  address: string;
  phone: string;
  website: string;
};

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  constructor(private appService: AppService) {}

  data: person[] = [];

  ngOnInit() {}

  callCompressedApi() {
    this.appService.compressedResponse().subscribe((res: any) => {
      // this.data = res;
    });
  }
  callNonCompressedApi() {
    this.appService.nonCompressedResponse().subscribe((res: any) => {
      // this.data = res;
    });
  }
}
