import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent {
    ngOnInit() {
        this.authLogin();
    }

    constructor(private route: Router) { }

    authLogin() {
        let login = localStorage.getItem("currentUser");

        if (login == null) { this.route.navigate(['/login']); }
        

    }
}
