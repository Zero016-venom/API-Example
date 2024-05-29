import { Injectable } from '@angular/core';
import { KoiThe } from "../models/koi-the";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class KoiTheService {
  koiThe: KoiThe[] = [];

  constructor(private httpClient: HttpClient) {
    
  }

  public getKoiThes(): Observable<KoiThe[]> {
    return this.httpClient.get<KoiThe[]>("https://localhost:44357/api/KoiThe");
  }
}
