import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Category } from '../_models/category';
import { Recipe } from '../_models/recipe';
import { CategoriesService } from './categories.service';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {
  baseUrl=environment.apiUrl;
  categoryN:string;


  constructor(private http:HttpClient) {

   }
 
  getRecipes(categoryId)
  {
    return this.http.get<Recipe[]>(this.baseUrl + 'recipe/getByCategory/' + categoryId);
  }

 
  getRecipeById(recipeId)
  {
   return this.http.get<Recipe[]>(this.baseUrl+'Recipe/getById/'+recipeId);
  }

  insertRecipe(recipe:Recipe)
  {
    //return this.http.post(this.baseUrl+'addRecipe?'+ recipe,{});
    return this.http.post(this.baseUrl+'Recipe/addRecipe', recipe);

  }
  
}


