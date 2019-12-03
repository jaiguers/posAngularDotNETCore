import { Component } from '@angular/core';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
    isExpanded = false;
    public isLogin: boolean;

    ngOnInit() {
        this.authLogin();
    }

    collapse() {
        this.isExpanded = false;
    }

    toggle() {
        this.isExpanded = !this.isExpanded;
    }

    authLogin() {
        let login = localStorage.getItem("currentUser");
        
        if (login != null) {
            this.isLogin = true;
        }
        else {
            this.isLogin = false;
        }

    }

}
