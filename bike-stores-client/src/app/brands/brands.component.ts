import { Component, OnInit } from '@angular/core';
import { BrandsService } from '../libs/api/v1';

@Component({
  selector: 'app-brands',
  templateUrl: './brands.component.html',
  styleUrls: ['./brands.component.scss']
})
export class BrandsComponent {
  brands$ = this.brandsService.brandsGet();

  constructor(private brandsService: BrandsService) { }
}
