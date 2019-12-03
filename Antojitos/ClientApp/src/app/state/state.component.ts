import { Component, OnInit } from '@angular/core';
import { StatesServiceService } from '../states-service.service';
import { StateInterface } from '../model/state-interface';

@Component({
    selector: 'app-state',
    templateUrl: './state.component.html',
    styleUrls: ['./state.component.css']
})
export class StateComponent implements OnInit {

    constructor(private st: StatesServiceService) { }

    private states: StateInterface;

    ngOnInit() {
        this.getAllStates();
    }

    getAllStates() {
        this.st.getAllStates().subscribe((data: StateInterface) => { this.states = data });
    }

    onTargetEdit(state: StateInterface): void {
        this.st.selectedState = Object.assign({}, state);
    }
}


