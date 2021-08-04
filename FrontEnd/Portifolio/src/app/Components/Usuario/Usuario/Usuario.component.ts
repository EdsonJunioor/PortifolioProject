import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import { Usuario } from 'src/app/Models/Usuario';
import { UsuarioService } from 'src/app/Service/Usuario.service';

@Component({
  selector: 'app-Usuario',
  templateUrl: './Usuario.component.html',
  styleUrls: ['./Usuario.component.css']
})
export class UsuarioComponent implements OnInit {

  public usuarios: Usuario[] = [] as Usuario[];
  public usuario: Usuario = new Usuario;

  public textoApresentacao = [
    { apresentacao: 'Olá me chamo Edson, moro em Sorocaba-SP e atualmente estou cursando o 5º semestre no curso de Análise e Desenvolvimento de Sistemas na universidade ESAMC Sorocaba (no momento chamada ATHON). Sou estagiário a 1 ano 2 meses na ITIX TI onde tive a oportunidade de estagiar 5 meses na equipe de desenvolvimento de software que é meu foco. Criei esse site com intenção de aprimorar e meu conhecimento em programação, ferramentas, conceitos e claro me divertir fazendo o que eu gosto.'},
    { ferramentas:  'ASP.NET - C# - Angular 12 - SQLServer'},
  ];

  constructor(private usuarioService: UsuarioService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.usuarioById(1);    //Aqui passei um id fixo para peger o meu usuario do banco
  }

  carregarUsuarios() {
    this.usuarioService.getAll().subscribe(
      (usuarios: Usuario[]) =>{
        this.usuarios = usuarios;
      }
    ),
    (erro: any) => {
      console.error('Erro ao carregar usuarios: ' + erro);
    }
  }
  
  usuarioById(id: number) {
    this.usuarioService.getById(id).subscribe(
      (usuario: Usuario) =>{
        this.usuario = usuario;
      }
    ),
    (erro: any) => {
      console.error('Erro ao carregar usuario: ' + erro);
    }
  }
}
