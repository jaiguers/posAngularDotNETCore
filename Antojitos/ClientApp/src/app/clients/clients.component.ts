import { Component, OnInit } from '@angular/core';
import { ClientsServiceService } from '../clients-service.service';
import { ClientInterface } from '../model/client-interface';

@Component({
    selector: 'app-clients',
    templateUrl: './clients.component.html',
    styleUrls: ['./clients.component.css']
})
export class ClientsComponent implements OnInit {

    constructor(private cltService: ClientsServiceService) { }
    private clients: ClientInterface;

    ngOnInit() {
        this.getAllClient();
    }

    getAllClient() {
        this.cltService.getAllSClient().subscribe((data: ClientInterface) => { this.clients = data });
    }

    onTargetEdit(data: ClientInterface): void {
        this.cltService.selectedClient = Object.assign({}, data);
    }

}
