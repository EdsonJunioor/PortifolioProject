import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from 'src/app/Models/Usuario';
import { UsuarioService } from 'src/app/Service/Usuario.service';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private usuarioService: UsuarioService ) {}

  ngOnInit() {
  }

  public usuariosTeste = [
    { id: '1',
      nome: 'Edson Junior',
      apresentacao: 'Criei esse site para práticar o que aprendi durante o meu perio de estágio, com objetivo de obter mais conhecimento e pratica com a programação.',
      habilidades: 'C#, Angular 8, SQL Server'
    }
    // {
    //   id: '2',
    //   nome: 'Mayara Almeida',
    //   apresentacao: 'Criei esse site para práticar o que aprendi durante o meu perio de estágio, com objetivo de obter mais conhecimento e pratica com a programação.',
    //   habilidades: 'Contabilidade, compras'
    // }
  ];

  public usuarios: Usuario[] = [] as Usuario[];

  buscarUsuarios(): Observable<Usuario[]> {
    return this.usuarioService.getAll();
  }
}
