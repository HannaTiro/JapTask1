import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesComponent } from './categories/categories.component';
import { HomeComponent } from './home/home.component';
import { CategoriesListComponent } from './members/categories-list/categories-list.component';
import { RecipeAddComponent } from './members/recipe-add/recipe-add.component';
import { RecipesDetailComponent } from './members/recipes-detail/recipes-detail.component';
import { RecipesListComponent } from './members/recipes-list/recipes-list.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'categories',component:CategoriesListComponent},
  {path:'recipes/:categoryId',component:RecipesListComponent},
  {path:'recipe/:recipeId',component:RecipesDetailComponent},
  {path:'recipeAdd',component:RecipeAddComponent}


  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
