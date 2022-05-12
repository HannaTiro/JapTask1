import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Recipe } from 'src/app/_models/recipe';
import { RecipesService } from 'src/app/_services/recipes.service';

@Component({
  selector: 'app-recipes-detail',
  templateUrl: './recipes-detail.component.html',
  styleUrls: ['./recipes-detail.component.css']
})
export class RecipesDetailComponent implements OnInit {
  recipes: Recipe[];
  recipeId;
  constructor(private recipeService:RecipesService, private route: ActivatedRoute) {
    this.recipeId = this.route.snapshot.paramMap.get('recipeId');
   }

  ngOnInit(): void {
    this.getRecipe();
  }
  getRecipe()
{
  this.recipeService.getRecipeById(this.recipeId).subscribe(recipes => {
    this.recipes = recipes;
  })
}
}
