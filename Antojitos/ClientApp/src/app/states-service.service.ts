import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StateInterface } from './model/state-interface';

@Injectable({
  providedIn: 'root'
})
export class StatesServiceService {
    readonly thisUrl = 'https://localhost:44350';
    public selectedState: StateInterface = {
        Id: null,
        Name: ''
    };

    constructor(private http: HttpClient) { }
    saveStates(state) {
        return this.http.post(this.thisUrl +'/api/states',state);
    }

    getAllStates() {
        return this.http.get(this.thisUrl + '/api/states');
    }

    editState(id) {
        return this.http.get(this.thisUrl + '/api/states/Edit'+id);
    }
}
