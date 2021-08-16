import { Component, OnInit } from '@angular/core';
import { FeatureService } from 'src/app/Service/Feature.service';

@Component({
  selector: 'app-Feature',
  templateUrl: './Feature.component.html',
  styleUrls: ['./Feature.component.css']
})
export class FeatureComponent implements OnInit {

  public features?: any[];

  constructor(public featureService: FeatureService) { }

  ngOnInit() {
    this.features = this.featureService.getFeatures();
  }

}
