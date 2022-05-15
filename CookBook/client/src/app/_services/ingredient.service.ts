import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Ingredient } from '../_models/ingredient';

@Injectable({
  providedIn: 'root'
})
export class IngredientService {
  baseUrl=environment.apiUrl;
  constructor(private http: HttpClient) { }
  getIngredients() {
    return this.http.get<Ingredient[]>(this.baseUrl+'Ingredient/getAll');
  }

  loadUnits() {
    return this.http.get<string[]>(this.baseUrl +'Ingredient/getUnits');
  }
}
