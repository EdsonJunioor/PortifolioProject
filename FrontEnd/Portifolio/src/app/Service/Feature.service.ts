import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {

  public feature: any[] = [];

  constructor() { }

  private features = [
    { codigo: 'Home', icone:'home' , descricao: 'A home atualmente criada somente com informações fixas e diretamente digitadas no html, falo um pouco do objetivo do app e as tecnologias usadas. Tenho objetivo de criado uma chamada ao banco para que o carregamento e prencimento das informações seja feita via chamada ao banco.'},
    { codigo: 'Usuário', icone: null, descricao: 'A tela de usuário (com referência no nav menu Edson Junior) é única tela por enquanto com a referencia a minha API, ela é composta por um Service tendo contato com a rota com a API no Environment.ts. Quando encontrada a rota pelo Angular, as informações estão sendo carregadas pelo método “ngOnInit()”, que faz uma chamada para um outro método tendo contato com o Service. O Service contem a rota da minha API fazendo o contato com o banco da aplicação, assim trazendo as informações da tela.'},
    { codigo: 'Features', icone: null, descricao: 'A feature criada também com carregamento local, criei um array de objetos em FeatureService e la é usado uma função que retorna todas as features do array, carregado na inicialização da tela na função "ngOnInit()", atribuindo a uma variavel no Feature.ts. Com ela declarada no Feature.ts conseguimos buscar o prenchimento dessa variavel no html usando a propridade do Angular "ngFor" em um dropdown select, mandando para uma outra variavel na propriedade "[(ngModel)]", com ela preenchida conseguindo trazer todas as propriedades do objeto Feature selecionado.'},
  ];

  public getFeatures(){
    return this.features;
  }

  public getFeatureByCodigo(codigo: string){
    return this.features.filter(f => f.codigo.includes(codigo));
  }
  
}
