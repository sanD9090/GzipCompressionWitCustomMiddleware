import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AppService {
  constructor(private http: HttpClient) {}

  compressedResponse(): Observable<any> {
    let url: string =
      'https://localhost:7253/api/Compression/CompressedResponse';

    return this.http.get(url);
  }
  nonCompressedResponse(): Observable<any> {
    let url: string =
      'https://localhost:7253/api/Compression/NonCompressedResponse';

    return this.http.get(url);
  }
}
