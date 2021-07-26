import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  public usuarios = [
    { nome: 'Edson Junior',
      apresentacao: 'Criei esse site para práticar o que aprendi durante o meu perio de estágio, com objetivo de obter mais conhecimento e pratica com a programação.',
      habilidades: 'C#, Angular 8, SQL Server'
    }
  ];
}
