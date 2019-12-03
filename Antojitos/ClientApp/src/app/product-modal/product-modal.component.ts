import { Component, OnInit } from '@angular/core';
import { ProductsServiceService } from '../products-service.service';
import { CategoryServiceService } from '../category-service.service';
import { NgForm } from '@angular/forms';
import { Location } from '@angular/common';
import { CategoryInterface } from '../model/category-interface';

@Component({
    selector: 'app-product-modal',
    templateUrl: './product-modal.component.html',
    styleUrls: ['./product-modal.component.css']
})
export class ProductModalComponent implements OnInit {
    readonly thisUrl = 'https://localhost:44350/api/';

    constructor(private prodService: ProductsServiceService, private catService: CategoryServiceService, private location: Location) { }
    private lstCategories: CategoryInterface;

    ngOnInit() {
        this.getCategories();
    }

    getCategories() {
        this.catService.getAllCategory().subscribe((data: CategoryInterface) => {
            this.lstCategories = data;
        });
    }

    onSave(prodForm: NgForm) {
        if (prodForm.value.id == null) {
            this.prodService.saveProduct(prodForm.value).subscribe(data => {
                if (data) {
                    alert('Guardado correctamente');
                }
            });
        }
        else {
            console.log('UPDATE PROD');
        }
    }
}
