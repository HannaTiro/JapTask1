import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Category } from '../_models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
baseUrl=environment.apiUrl;
  constructor(private http:HttpClient) { }

  getCategories()
{
  return this.http.get<Category[]>(this.baseUrl+'category');
}

getCategory(categoryName){
return this.http.get<Category>(this.baseUrl+'category/'+categoryName);
}
}
