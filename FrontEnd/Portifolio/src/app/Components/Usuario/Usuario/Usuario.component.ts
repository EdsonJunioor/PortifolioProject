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

  public apresentacao = [
    { nome: 'Edson Junior'},
    { apresentacao: 'Olá me chamo Edson, moro em Sorocaba-SP e atualmente estou cursando o 5º semestre no curso de Análise e Desenvolvimento de Sistemas na universidade ESAMC Sorocaba (no momento chamada ATHON). Sou estagiário a 1 ano 2 meses na ITIX TI onde tive a oportunidade de estagiar 5 meses na equipe de desenvolvimento de software que é meu foco. Criei esse site com intenção de aprimorar e meu conhecimento em programação, ferramentas, conceitos e claro me divertir fazendo o que eu gosto.'},
    { tecnologias:  'ASP.NET C# Angular SQLServer Oracle'},
  ];

  public experiencias = [
    { empresa: 'ITIX (07/2020 - Atual)'},
    { cargo: 'Estágiario de Desenvolvimento de Software'},
    { descricao: 'Reconstrução de sistema de apontamento de horas interno da empresa usando as tecnologias: JAVA, ANGULAR 8, ORACLE e Git. Atendimentos direto de demandas solicitadas conforme o planejamento. Projeto desenvolvido usando as tecnologias: JAVA, ANGULAR 8, ORACLE, Git e DevOps. Participação em grande projeto tendo contato com cliente e atendendo as demandas conforme o planejamento, nesse projeto tive a experiência com as seguintes tecnologias: ASP.NET, C#, Angular JS, SQL Server, Git e DevOps.'}
  ];

  constructor(private usuarioService: UsuarioService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.usuarioById(2);    //Aqui passei um id fixo para peger o meu usuario do banco
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
