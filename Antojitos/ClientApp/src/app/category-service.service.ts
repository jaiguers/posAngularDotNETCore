import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CategoryInterface } from './model/category-interface';

@Injectable({
  providedIn: 'root'
})
export class CategoryServiceService {

    readonly thisUrl = 'https://localhost:44350/api/';
    public selectedCategory: CategoryInterface = {
        Id: null,
        Name: ''
    };

    constructor(private http: HttpClient) { }

    getAllCategory() {
        return this.http.get(this.thisUrl+'category');
    }
}
