import { Component, OnInit } from '@angular/core';
import { SalesServiceService } from '../sales-service.service';
import { ClientsServiceService } from '../clients-service.service';
import { ProductsServiceService } from '../products-service.service';
import { PaymentMethodsService } from '../payment-methods.service';
import { ClientInterface } from '../model/client-interface';
import { ProductInterface } from '../model/product-interface';
import { SaleInterface } from '../model/sale-interface';
import { NgForm } from '@angular/forms';


@Component({
    selector: 'app-create-sales',
    templateUrl: './create-sales.component.html',
    styleUrls: ['./create-sales.component.css']
})
export class CreateSalesComponent implements OnInit {

    constructor(
        private saleService: SalesServiceService,
        private clService: ClientsServiceService,
        private prodService: ProductsServiceService,
        private payService: PaymentMethodsService
    ) { }

    lstClients: ClientInterface;
    lstProducts: ProductInterface;
    selectedProduct: ProductInterface[];
    currentSale: SaleInterface = {
        id: null,
        clientId: '',
        clientName: '',
        userId: '',
        userName: '',
        code: '',
        iva: '',
        netoWorth: '',
        total: '',
        paymentMethodId: '',
        paymentName: '',
        details: '',
    };
    total: number;
    iva: number;
    clientId: string;


    ngOnInit() {
        this.getAllProdct();
        this.getAllClient();
        this.selectedProduct = [];
        this.total = 0;
    }

    getAllProdct() {

        this.prodService.getAllProduct().subscribe((data: ProductInterface) => { this.lstProducts = data; });
    }

    getAllClient() {
        this.clService.getAllSClient().subscribe((data: ClientInterface) => { this.lstClients = data });
    }

    onSelect(prod: ProductInterface): void {


        let lessStock = Number(prod.stock);
        if (lessStock > 0) {
            prod.stock = (lessStock - 1) + "";
            this.selectedProduct.push(prod);
            this.total = this.total + (Number(prod.salePrice));
            this.iva = this.total * 0.19;
        } else {
            alert("Producto agotado");
        }

    }

    onSelectClient(clientId: string) {

        this.clientId = clientId;
    }

    onSave() {
        this.currentSale.clientId = "1";
        this.currentSale.total = this.total + "";
        this.currentSale.iva = this.iva + "";
        this.currentSale.details = '';

        //this.selectedProduct.toString();
        var send: SaleInterface= {
            clientName: '',
            userId: '',
            userName: '',
            code: '',
            netoWorth: '',
            paymentMethodId: '',
            paymentName: '',
            clientId: this.currentSale.clientId,
            total: this.total + "",
            iva: this.iva + "",
            details: '',
        };
        console.log(send);
        this.saleService.saveSale(send).subscribe((data: SaleInterface) => {
            if (data) {
                alert("Venta guardada correctamente");
            }
        });
    }
}
