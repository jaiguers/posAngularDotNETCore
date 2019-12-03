import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProductInterface } from './model/product-interface';

@Injectable({
    providedIn: 'root'
})
export class ProductsServiceService {
    readonly thisUrl = 'https://localhost:44350/api/';
    public selectedProduct: ProductInterface = {
        id: null,
        name: '',
        code: '',
        image: '',
        purchasePrice: '',
        salePrice: '',
        stock: '',
        purchased: '',
        categoryId:''
    };

    constructor(private http: HttpClient) { }
    saveProduct(prod) {
        return this.http.post(this.thisUrl + 'product', prod);
    }

    getAllProduct() {
        return this.http.get(this.thisUrl + 'product');
    }

    editState(id) {
        return this.http.get(this.thisUrl + '/api/states/Edit' + id);
    }
}


