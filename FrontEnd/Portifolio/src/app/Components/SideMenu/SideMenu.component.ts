import { Component, OnInit } from '@angular/core';
import { Usuario } from 'src/app/Models/Usuario';
import { FeatureService } from 'src/app/Service/Feature.service';

@Component({
  selector: 'app-SideMenu',
  templateUrl: './SideMenu.component.html',
  styleUrls: ['./SideMenu.component.css']
})
export class SideMenuComponent implements OnInit {

  public usuario: Usuario[] = [];

  constructor(private featuresService: FeatureService) { }

  ngOnInit() {
  }

  public usuarios = [
    { nome: 'Edson Junior',
      apresentacao: 'Criei esse site para práticar o que aprendi durante o meu perio de estágio, com objetivo de obter mais conhecimento e pratica com a programação.',
      habilidades: 'C#, Angular 8, SQL Server'
    }
  ];

}