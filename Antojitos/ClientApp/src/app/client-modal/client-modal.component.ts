import { Component, OnInit } from '@angular/core';
import { ClientsServiceService } from '../clients-service.service';
import { StatesServiceService } from '../states-service.service';
import { NgForm } from '@angular/forms';
import { Location } from '@angular/common';
import { StateInterface } from '../model/state-interface';

@Component({
    selector: 'app-client-modal',
    templateUrl: './client-modal.component.html',
    styleUrls: ['./client-modal.component.css']
})
export class ClientModalComponent implements OnInit {

    constructor(private clService: ClientsServiceService, private stService: StatesServiceService, private location: Location) { }
    private lstStates: StateInterface;

    ngOnInit() {
        this.getStates();
    }

    getStates() {
        this.stService.getAllStates().subscribe((data: StateInterface) => { this.lstStates = data });
    }

    onSaveClient(clientForm: NgForm) {
        if (clientForm.value.id == null) {
            this.clService.saveClient(clientForm.value).subscribe(data => {
                if (data) {
                    alert('Guardado correctamente');
                }
            });
        }
        else {
            console.log('UPDATE CLI');
        }
    }
}
