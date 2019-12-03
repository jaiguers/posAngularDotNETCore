import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { StatesServiceService } from '../states-service.service';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-create-state',
    templateUrl: './create-state.component.html',
    styleUrls: ['./create-state.component.css']
})
export class CreateStateComponent implements OnInit {

    constructor(private st: StatesServiceService) {

    }

    customerForm: FormGroup
    name: FormControl

    ngOnInit() {
        this.name = new FormControl('', [Validators.required]);
        this.customerForm = new FormGroup({
            name: this.name
        });
    }

    ValidateName() {
        return this.name.valid || this.name.untouched;
    }

    saveStates(obj: any) {
        this.st.saveStates(obj).subscribe((data): any => {
            if (data) {
                alert('Guardado correctamente');
            }
            this.customerForm.reset;
        });
    }

}
