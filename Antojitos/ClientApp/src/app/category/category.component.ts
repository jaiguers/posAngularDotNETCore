import { Component, OnInit } from '@angular/core';
import { CategoryServiceService } from '../category-service.service';
import { CategoryInterface } from '../model/category-interface';

@Component({
    selector: 'app-category',
    templateUrl: './category.component.html',
    styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

    constructor(private catService: CategoryServiceService) { }
    private categories: CategoryInterface;


    ngOnInit() {
        this.getAllCategory();
    }

    getAllCategory() {
        this.catService.getAllCategory().subscribe((data: CategoryInterface) => { this.categories = data });
    }

}
