import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/_models/category';
import { Pagination } from 'src/app/_models/pagination';
import { CategoriesService } from 'src/app/_services/categories.service';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit {
categories:Category[];
pagination:Pagination;
pageNumber=1;
pageSize=10;
  constructor(private categoryService:CategoriesService) { }

  ngOnInit(): void {
    this.loadCategories();
}
/* loadCategories()
{
  this.categoryService.getCategories().subscribe(category=>{
    this.categories=category;
  })
} */

loadCategories(){
  this.categoryService.getCategoriesPag(this.pageNumber,this.pageSize).subscribe(category=>{
    this.categories=category.result;
    this.pagination=category.pagination;
  })
}

pageChanged(event:any)
{
  this.pageNumber=event.page;
  this.loadCategories();
}

}
