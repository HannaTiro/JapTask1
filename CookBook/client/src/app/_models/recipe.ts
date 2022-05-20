import { Ingredient } from "./ingredient";

export interface Recipe{
  id:number;
  name:string;
  description:string;
totalPrice:number;
categoryId:number;
ingredients:Ingredient[];
}

