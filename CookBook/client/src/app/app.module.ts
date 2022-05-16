import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { CategoriesComponent } from './categories/categories.component';
import { CategoriesListComponent } from './members/categories-list/categories-list.component';
import { RecipesListComponent } from './members/recipes-list/recipes-list.component';
import { RecipesDetailComponent } from './members/recipes-detail/recipes-detail.component';
import { RecipeAddComponent } from './members/recipe-add/recipe-add.component';
import { CategoryCardComponent } from './members/category-card/category-card.component';
import { RecipeCardComponent } from './members/recipe-card/recipe-card.component';
import { TextInputComponent } from './_forms/text-input/text-input.component';
import { IngredientsRecipeAddComponent } from './members/ingredients-recipe-add/ingredients-recipe-add.component';
import{PaginationModule} from 'ngx-bootstrap/pagination';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    CategoriesComponent,
    CategoriesListComponent,
    RecipesListComponent,
    RecipesDetailComponent,
    RecipeAddComponent,
    CategoryCardComponent,
    RecipeCardComponent,
    TextInputComponent,
    IngredientsRecipeAddComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    PaginationModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
