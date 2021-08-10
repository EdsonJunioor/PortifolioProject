import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Components/Home/Home.component';
import { UsuarioComponent } from './Components/Usuario/Usuario/Usuario.component';

const routes: Routes = [  //todas as rotas/componentes devem ser sitados aqui
  { path: '', redirectTo: 'home', pathMatch:'full'}, // redirectTo redireciona para uma rota padrao quando nao esta em nenhuma outra rota do site
  { path: 'home', component: HomeComponent},
  { path: 'usuario', component: UsuarioComponent}  //sintaxe para configuração de um outro componente criado no app
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
