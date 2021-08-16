import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {

constructor() { }

private features = [
  { icone:'home' , descricao: 'A home atualmente criada somente com informações fixas e diretamente digitadas no html, falo um pouco do objetivo do app e as tecnologias usadas. Tenho objetivo de criado uma chamada ao banco para que o carregamento e prencimento das informações seja feita via chamada ao banco.'}

];

public getFeatures(){
  return this.features;
}

}
