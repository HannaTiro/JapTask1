import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { insertIngredientRequest } from '../_models/InsertIngredientRequest';
import { ReciepeDetail } from '../_models/reciepeDetail';


@Injectable({
  providedIn: 'root'
})
export class RecipeDetailService {
  baseUrl=environment.apiUrl;


  constructor(private http:HttpClient) { }

  addIngredient(recipeId:number,request:insertIngredientRequest)
  {
    //return this.http.post(this.baseUrl+'addRecipe?'+ recipe,{});
    return this.http.post(this.baseUrl+'RecipeDetails/addIngredient/'+recipeId+'/', request);

  }
  getIngredients(recipeId)
  {
    return this.http.get<ReciepeDetail[]>(this.baseUrl+'RecipeDetails/getIngredientsForRecipe/'+recipeId);
  }
}
