import { Component, OnInit } from '@angular/core';
import { RolServiceService } from '../rol-service.service';
import { RolInterface } from '../model/rol-interface';

@Component({
  selector: 'app-rol',
  templateUrl: './rol.component.html',
  styleUrls: ['./rol.component.css']
})
export class RolComponent implements OnInit {

    constructor(private rolService: RolServiceService) { }

    private roles: RolInterface;

    ngOnInit() {
        this.getAllRol();
  }

    getAllRol() {
        this.rolService.getAllRol().subscribe((data: RolInterface) => { this.roles = data });
    }

}
