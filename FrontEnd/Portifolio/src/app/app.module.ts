import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideMenuComponent } from './Components/SideMenu/SideMenu.component';
import { UsuarioComponent } from './Components/Usuario/Usuario/Usuario.component';
import { FooterComponent } from './Components/Footer/Footer.component';


@NgModule({
  declarations: [
    AppComponent,
    UsuarioComponent,
    SideMenuComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
