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

  constructor(private usuarioService: UsuarioService, private route: ActivatedRoute) { }
  
  public id!: number;

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
