import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Category } from '../_models/category';
import { PaginatedResult } from '../_models/pagination';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
baseUrl=environment.apiUrl;
paginatedResult:PaginatedResult<Category[]>=new PaginatedResult<Category[]>();
  constructor(private http:HttpClient) { }

  getCategoriesPag(page?:number, itemsPerPage?:number)
{
  let params=new HttpParams();
  if(page!==null && itemsPerPage!==null)
  {
    params=params.append('pageNumber',page.toString());
    params=params.append('pageSize',itemsPerPage.toString());

  }
  return this.http.get<Category[]>
         (this.baseUrl+'Categories/page', {observe:'response',params}).pipe(
           map(response=>{
             this.paginatedResult.result=response.body;
             if(response.headers.get('Pagination')!==null){
               this.paginatedResult.pagination=JSON.parse(response.headers.get('Pagination'));
             }
             return this.paginatedResult;
           })
         )
    
}
getCategories()
{
  return this.http.get<Category[]>(this.baseUrl+'Categories');
}


getCategory(categoryName){
return this.http.get<Category>(this.baseUrl+'Categories/'+categoryName);
}
}
