import { Component, OnInit } from '@angular/core';
import { StatesServiceService } from '../states-service.service';
import { HttpClient } from '@angular/common/http';


@Component({
    selector: 'app-states',
    templateUrl: './states.component.html',
    styleUrls: ['./states.component.css']
})
export class StatesComponent implements OnInit {

    constructor(private st: StatesServiceService) {
        this.getAllStates()
    }
    data: any;

    ngOnInit() {
    }

    getAllStates() {
        this.st.getAllStates().subscribe((data): any => {
            if (data) {
                this.data = data;
            }
        });
    }


    settings = {
        actions:false,
        pager: {
            display: true,
            perPage: 7
        },
        columns: {
            name: {
                title: 'Nombre'
            }
        }
    };
}
