import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StateInterface } from './model/state-interface';

@Injectable({
  providedIn: 'root'
})
export class RolServiceService {
    readonly thisUrl = 'https://localhost:44350/api/';
    
    constructor(private http: HttpClient) { }

    getAllRol() {
        return this.http.get(this.thisUrl + 'rol');
    }
}
