import { Ingredient } from "./ingredient";
import { Recipe } from "./recipe";
import { unitsEnum } from "./unitsEnum";

export interface ReciepeDetail {
    reciepeDetailId: number;
    amount: number;
   // measure:string;
    measure:unitsEnum;
    price:number;
    ingredient:Ingredient;
    recipe:Recipe;
    cost:number;
 }