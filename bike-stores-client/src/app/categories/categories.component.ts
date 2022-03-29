import { Component, OnInit } from '@angular/core';
import { CategoriesService } from '../libs/api/v1';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent {
  categories$ = this.categoriesService.categoriesGet();

  constructor(private categoriesService: CategoriesService) { }
}
