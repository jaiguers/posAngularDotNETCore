import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SalesServiceService {

    constructor(private http: HttpClient) { }

    readonly thisUrl = 'https://localhost:44350/api/';
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json; charset=utf-8'
        })
    }

    getAllSale() {
        return this.http.get(this.thisUrl + 'sales');
    }

    saveSale(sale) {
        return this.http.post(this.thisUrl + 'sales', sale, this.httpOptions);
    }
}
