import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/_models/category';
import { CategoriesService } from 'src/app/_services/categories.service';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit {
categories:Category[];
  constructor(private categoryService:CategoriesService) { }

  ngOnInit(): void {
    this.loadCategories();
}
loadCategories()
{
  this.categoryService.getCategories().subscribe(category=>{
    this.categories=category;
  })
}
}
