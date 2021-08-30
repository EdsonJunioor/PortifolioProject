import { Component, OnInit } from '@angular/core';
import { Feature } from 'src/app/Models/Feature';
import { FeatureService } from 'src/app/Service/Feature.service';

@Component({
  selector: 'app-Feature',
  templateUrl: './Feature.component.html',
  styleUrls: ['./Feature.component.css']
})
export class FeatureComponent implements OnInit {

  public features?: any[];
  public featureSelecionada: any;

  constructor(public featureService: FeatureService, ) { }

  ngOnInit() {
    this.features = this.featureService.getFeatures();
  }

}
