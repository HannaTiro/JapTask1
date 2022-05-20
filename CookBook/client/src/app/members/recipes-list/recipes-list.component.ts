import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/_models/category';
import { Pagination } from 'src/app/_models/pagination';
import { Recipe } from 'src/app/_models/recipe';
import { CategoriesService } from 'src/app/_services/categories.service';
import { RecipesService } from 'src/app/_services/recipes.service';

@Component({
  selector: 'app-recipes-list',
  templateUrl: './recipes-list.component.html',
  styleUrls: ['./recipes-list.component.css']
})
export class RecipesListComponent implements OnInit {
  category: Category;
  recipes: Recipe[];
  categoryName: string;
  categoryId;
  pagination:Pagination;
  pageNumber=1;
  pageSize=10;
  constructor(private categoryService: CategoriesService, private route: ActivatedRoute, private recipeService: RecipesService) {
    this.categoryId = this.route.snapshot.paramMap.get('id');
  }

  ngOnInit(): void {
  // this.loadCategoryName();
    this.loadRecipes();
  }
  
  loadCategoryName() {
    this.categoryService.getCategory(this.categoryId).subscribe(category => {
      this.category = category;
      this.categoryName = category.name;
      
    })
  }

/*   getRecipes() {
    this.recipeService.getRecipes(this.categoryId).subscribe(recipes => {
      this.recipes = recipes;
    })
  }  */

  //nova
  loadRecipes(){
    this.recipeService.getRecipesPaged(this.categoryId,this.pageNumber,this.pageSize).subscribe(recipe=>{
      this.recipes=recipe.result;
      this.pagination=recipe.pagination;
    })
  }
  pageChanged(event:any)
{
  this.pageNumber=event.page;
  this.loadRecipes();
}
}


