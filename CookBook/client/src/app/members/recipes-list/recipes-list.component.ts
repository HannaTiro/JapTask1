import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/_models/category';
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
  constructor(private categoryService: CategoriesService, private route: ActivatedRoute, private recipeService: RecipesService) {
    this.categoryId = this.route.snapshot.paramMap.get('categoryId');
  }

  ngOnInit(): void {
   // this.loadCategoryName();
    this.getRecipes();
  }
  
  loadCategoryName() {
    this.categoryService.getCategory(this.categoryId).subscribe(category => {
      this.category = category;
      this.categoryName = category.categoryName;
    })
  }

  getRecipes() {
    this.recipeService.getRecipes(this.categoryId).subscribe(recipes => {
      this.recipes = recipes;
    })
  }
}


