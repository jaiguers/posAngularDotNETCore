import { Component, OnInit } from '@angular/core';
import { SalesServiceService } from '../sales-service.service';
import { SaleInterface } from '../model/sale-interface';

@Component({
  selector: 'app-sales',
  templateUrl: './sales.component.html',
  styleUrls: ['./sales.component.css']
})
export class SalesComponent implements OnInit {

    constructor(private saleService: SalesServiceService) { }
    private lstSales: SaleInterface;

    ngOnInit() {
        this.getAllSale();
  }

    getAllSale() {
        this.saleService.getAllSale().subscribe((data: SaleInterface) => { this.lstSales = data });;
    }
}
