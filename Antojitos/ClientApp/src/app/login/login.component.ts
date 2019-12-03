import { Component, OnInit } from '@angular/core';
import { UsersServiceService } from '../users-service.service';
import { UserInterface } from '../model/user-interface';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    constructor(private userService: UsersServiceService, private route: Router) { }
    private user: UserInterface = {
        login: "",
        password: ""
    };

    ngOnInit() {
    }

    onLogin() {
        return this.userService.login(this.user.login, this.user.password).subscribe((data: UserInterface) => {
            console.log(data);
            if (data.id != null) {
                this.userService.setUser(this.user);
                this.userService.setToken(data.id);
                this.route.navigate(['/']);
            }
            else {
                alert("Usuario no encontrado");
            }

        },
            error => {
                console.log("Error:");
                console.log(error);
            });
    }
}
