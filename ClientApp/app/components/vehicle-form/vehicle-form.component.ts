import { VehicleService } from './../../services/vehicle.service';
import { FeatureService } from './../../services/feature.service';
import { MakeService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})

export class VehicleFormComponent implements OnInit {
  makes : any[];
  features : any[];
  models : any;
  vehicle : any = {};

  constructor(
    private vehicleService : VehicleService
    ) { }

  ngOnInit() {
    this.vehicleService.getMakes().subscribe(makes => {
      this.makes = makes;
    });

    this.vehicleService.getFeatures().subscribe(features => {
      this.features = features;
    });
  }

  onMakeChange() {
    var selectMakes = this.makes.find(m=> m.id == this.vehicle.make);
    this.models = selectMakes ? selectMakes.models : [];
  }
}
