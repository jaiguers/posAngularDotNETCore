import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { StatesComponent } from './states/states.component';
import { CategoryComponent } from './category/category.component';
import { UsersComponent } from './users/users.component';
import { ProductsComponent } from './products/products.component';
import { RolComponent } from './rol/rol.component';
import { ClientsComponent } from './clients/clients.component';
import { SalesComponent } from './sales/sales.component';
import { Ng2SmartTableModule } from 'ng2-smart-table';
import { CreateStateComponent } from './create-state/create-state.component';
import { StatesServiceService } from './states-service.service';
import { ModalComponent } from './modal/modal.component';
import { StateComponent } from './state/state.component';
import { UserModalComponent } from './user-modal/user-modal.component';
import { ClientModalComponent } from './client-modal/client-modal.component';
import { CreateSalesComponent } from './create-sales/create-sales.component';
import { ProductModalComponent } from './product-modal/product-modal.component';
import { LoginComponent } from './login/login.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        StatesComponent,
        CategoryComponent,
        UsersComponent,
        ProductsComponent,
        RolComponent,
        ClientsComponent,
        SalesComponent,
        CreateStateComponent,
        ModalComponent,
        StateComponent,
        UserModalComponent,
        ClientModalComponent,
        CreateSalesComponent,
        ProductModalComponent,
        LoginComponent,
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        Ng2SmartTableModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full' },
            { path: 'states', component: StatesComponent },
            { path: 'category', component: CategoryComponent },
            { path: 'users', component: UsersComponent },
            { path: 'products', component: ProductsComponent },
            { path: 'rol', component: RolComponent },
            { path: 'clients', component: ClientsComponent },
            { path: 'sales', component: SalesComponent },
            { path: 'createState', component: CreateStateComponent },
            { path: 'state', component: StateComponent },
            { path: 'createSale', component: CreateSalesComponent },
            { path: 'login', component: LoginComponent },
        ])
    ],
    providers: [StatesServiceService],
    bootstrap: [AppComponent]
})
export class AppModule { }
