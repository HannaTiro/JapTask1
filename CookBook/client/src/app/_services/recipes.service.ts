import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Category } from '../_models/category';
import { ReciepeDetail } from '../_models/reciepeDetail';
import { Recipe } from '../_models/recipe';
import { CategoriesService } from './categories.service';
import { map } from 'rxjs/operators';
import { PaginatedResult } from '../_models/pagination';


@Injectable({
  providedIn: 'root'
})
export class RecipesService {
  baseUrl=environment.apiUrl;
  categoryN:string;
paginatedResult:PaginatedResult<Recipe[]>=new PaginatedResult<Recipe[]>();



  constructor(private http:HttpClient) {

   }
 
  getRecipes(categoryId)
  {
    return this.http.get<Recipe[]>(this.baseUrl + 'recipe/getByCategory/' + categoryId);
  }

 
  getRecipesPaged(categoryId,page?:number, itemsPerPage?:number)
  {
    let params=new HttpParams();
    if(page!==null && itemsPerPage!==null)
    {
      params=params.append('pageNumber',page.toString());
      params=params.append('pageSize',itemsPerPage.toString());
  
    }
    return this.http.get<Recipe[]>
           (this.baseUrl+'recipe/getRecipesPage/'+categoryId+'/', {observe:'response',params}).pipe(
             map(response=>{
               this.paginatedResult.result=response.body;
               if(response.headers.get('Pagination')!==null){
                 this.paginatedResult.pagination=JSON.parse(response.headers.get('Pagination'));
               }
               return this.paginatedResult;
             })
           )
      
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
  getIngredients(recipeId)
  {
    return this.http.get<ReciepeDetail[]>(this.baseUrl+'Recipe/getIngredientsRecipe/'+recipeId);
  }

  
}


