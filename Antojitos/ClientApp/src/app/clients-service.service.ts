import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ClientInterface } from './model/client-interface';

@Injectable({
    providedIn: 'root'
})
export class ClientsServiceService {
    readonly thisUrl = 'https://localhost:44350/api/';
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json; charset=utf-8'
        })
    }
    public selectedClient: ClientInterface = {
        Id: null,
        Name: '',
        Surnames: '',
        Identification: '',
        Address: '',
        Phone: '',
        Email: '',
        StateId: ''
    };

    constructor(private http: HttpClient) { }

    saveClient(client) {
        return this.http.post(this.thisUrl + 'client', client, this.httpOptions);
    }

    getAllSClient() {
        return this.http.get(this.thisUrl + 'client');
    }

}
