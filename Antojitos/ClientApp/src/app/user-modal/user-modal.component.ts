import { Component, OnInit } from '@angular/core';
import { UsersServiceService } from '../users-service.service';
import { NgForm } from '@angular/forms';
import { Location } from '@angular/common';

@Component({
    selector: 'app-user-modal',
    templateUrl: './user-modal.component.html',
    styleUrls: ['./user-modal.component.css']
})
export class UserModalComponent implements OnInit {

    constructor(private usService: UsersServiceService, private location: Location) { }
    
    ngOnInit() {
    }

    onSaveUser(userForm: NgForm) {
        if (userForm.value.id == null) {
                                  
            this.usService.saveUser(userForm.value).subscribe(data => {
                if (data) {
                    alert('Guardado correctamente');
                    location.reload();
                }
            });
        }
        else {
            console.log('UPDATE');
        }
        
    }
}
