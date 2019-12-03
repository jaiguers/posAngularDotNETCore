import { Component, OnInit } from '@angular/core';
import { ProductsServiceService } from '../products-service.service';
import { ProductInterface } from '../model/product-interface';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

    constructor(private prodService: ProductsServiceService) { }
    private products: ProductInterface;

    ngOnInit() {
        this.getAllProduct();
    }

    getAllProduct() {
        this.prodService.getAllProduct().subscribe((data: ProductInterface) => { this.products = data });
    }

    onTargetEdit(data: ProductInterface): void {
        this.prodService.selectedProduct = Object.assign({}, data);
    }

}
