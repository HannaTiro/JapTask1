import { i18nMetaToJSDoc } from '@angular/compiler/src/render3/view/i18n/meta';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Ingredient } from 'src/app/_models/ingredient';
import { ReciepeDetail } from 'src/app/_models/reciepeDetail';
import { Recipe } from 'src/app/_models/recipe';
import { RecipeDetailService } from 'src/app/_services/recipe-detail.service';
import { RecipesService } from 'src/app/_services/recipes.service';

@Component({
  selector: 'app-recipes-detail',
  templateUrl: './recipes-detail.component.html',
  styleUrls: ['./recipes-detail.component.css']
})
export class RecipesDetailComponent implements OnInit {
  recipes: Recipe[];
  recipeId;
  ingredients:ReciepeDetail[];
  constructor(private recipeService:RecipesService, private route: ActivatedRoute,private recipeDetailsService:RecipeDetailService) {
    this.recipeId = this.route.snapshot.paramMap.get('recipeId');
   }

  ngOnInit(): void {
    this.getRecipe();
    this.getIngredients();
  }
  getRecipe()
{
  this.recipeService.getRecipeById(this.recipeId).subscribe(recipes => {
    this.recipes = recipes;
  })
}

// getIngredients(){
//   this.recipeService.getIngredients(this.recipeId).subscribe(ingred=>{
//     this.ingredients=ingred;
//   })
// }
getIngredients(){
  this.recipeDetailsService.getIngredients(this.recipeId).subscribe(ingred=>{
    this.ingredients=ingred;
  })
}
}
