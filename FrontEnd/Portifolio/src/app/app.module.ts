import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideMenuComponent } from './Components/SideMenu/SideMenu.component';
import { UsuarioComponent } from './Components/Usuario/Usuario/Usuario.component';
import { FooterComponent } from './Components/Footer/Footer.component';
import { FeatureComponent } from './Components/Feature/Feature.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CadastroUsuarioComponent } from './Components/Cadastro/CadastroUsuario/CadastroUsuario.component';



@NgModule({
  declarations: [
    AppComponent,
    UsuarioComponent,
    SideMenuComponent,
    FooterComponent,
    FeatureComponent,
    CadastroUsuarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BsDropdownModule.forRoot(),
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
