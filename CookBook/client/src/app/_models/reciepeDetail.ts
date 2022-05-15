import { Ingredient } from "./ingredient";
import { Recipe } from "./recipe";

export interface ReciepeDetail {
    reciepeDetailId: number;
    amount: number;
    measure:string;
    price:number;
    ingredient:Ingredient;
    recipe:Recipe;
    cost:number;
 }