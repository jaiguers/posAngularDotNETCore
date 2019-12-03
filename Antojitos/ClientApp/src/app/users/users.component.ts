import { Component, OnInit } from '@angular/core';
import { UsersServiceService } from '../users-service.service';
import { UserInterface } from '../model/user-interface';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

    constructor(private usService: UsersServiceService) { }
    private users: UserInterface;

    ngOnInit() {
        this.getAllUser();
    }

    getAllUser() {

        this.usService.getAllUser().subscribe((data: UserInterface) => { this.users = data });
        
    }

    onTargetEdit(state: UserInterface): void {
        this.usService.selectedUser = Object.assign({}, state);
    }

}
