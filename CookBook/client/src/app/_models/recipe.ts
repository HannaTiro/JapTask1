import { Ingredient } from "./ingredient";

export interface Recipe{
  recipeId:number;
  recipeName:string;
  description:string;
totalPrice:number;
categoryId:number;
ingredients:Ingredient[];
}

