import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DadosPessoaisComponent } from './Components/Cadastro/DadosPessoais/DadosPessoais.component';
import { FeatureComponent } from './Components/Feature/Feature.component';
import { HomeComponent } from './Components/Home/Home.component';
import { UsuarioComponent } from './Components/Usuario/Usuario/Usuario.component';

const routes: Routes = [                              //todas as rotas/componentes devem ser sitados aqui
  { path: 'home', component: HomeComponent},          //sintaxe para configuração de um outro componente criado no app
  { path: 'dadosPessoais', component: DadosPessoaisComponent},
  { path: 'usuario', component: UsuarioComponent},
  { path: 'features', component: FeatureComponent},
  { path: '', redirectTo: 'home', pathMatch:'full'},  // redirectTo redireciona para uma rota padrao quando nao esta em nenhuma outra rota do site
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
