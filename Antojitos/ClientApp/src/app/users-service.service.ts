import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { UserInterface } from './model/user-interface';

@Injectable({
    providedIn: 'root'
})
export class UsersServiceService {

    constructor(private http: HttpClient) { }

    readonly thisUrl = 'https://localhost:44350/api/';
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json; charset=utf-8'
        })
    }
    public selectedUser: UserInterface = {
        id: null,
        login: '',
        password:'',
        stateId: ''
    };

    

    getAllUser() {
        return this.http.get(this.thisUrl + 'users');
    }

    saveUser(user) {
        
        return this.http.post(this.thisUrl + 'users', user, this.httpOptions);
    }

    editState(id) {
        return this.http.get(this.thisUrl + 'users/Edit' + id);
    }

    login(login, passw) {
        let user: any = {
            login: login,
            password: passw
        }
        return this.http.post(this.thisUrl + 'Users/login', user, this.httpOptions);
    }

    setUser(user: UserInterface) {
        localStorage.setItem("currentUser", user.login);
    }

    setToken(token) {
        localStorage.setItem("thisToken", token);

    }
}
