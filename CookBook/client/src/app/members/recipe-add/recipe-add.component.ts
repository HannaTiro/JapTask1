import { RecurseVisitor } from '@angular/compiler/src/i18n/i18n_ast';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Category } from 'src/app/_models/category';
import { Recipe } from 'src/app/_models/recipe';
import { CategoriesService } from 'src/app/_services/categories.service';
import { RecipesService } from 'src/app/_services/recipes.service';

@Component({
  selector: 'app-recipe-add',
  templateUrl: './recipe-add.component.html',
  styleUrls: ['./recipe-add.component.css']
})
export class RecipeAddComponent implements OnInit {
  @ViewChild('addForm') addForm:NgForm; 
  category: Category[];
  selectedCategory:any;
recipeAddForm:FormGroup;



  constructor(private recipesService:RecipesService,
    private route: ActivatedRoute,
    private categoryService: CategoriesService,
    private fb:FormBuilder,
    private router:Router) { 
  

  }

  ngOnInit(): void {
this.getCategories();
this.initializeForm();
  }

  initializeForm(){
    this.recipeAddForm=this.fb.group({
      name: ['',Validators.required],
      description:['',Validators.required],
      categoryId:['',Validators.required ]

    })
  }


  ChangeCategory(e)
  {
//console.log(e.target.value);
this.selectedCategory=e.target.value;
  }

 /*  insertRecipe(recipe:Recipe)
  {
this.recipesService.insertRecipe(recipe).subscribe(()=>{
  this.addForm.reset();
})
  } */
//  {path:'recipes/:categoryId',component:RecipesListComponent}, ->navigacija za kasnije poslije submita uzeti categoryid

  testSubmit()
  {
    console.log(this.recipeAddForm.value);
    this.recipesService.insertRecipe(this.recipeAddForm.value).subscribe(()=>{
      this.router.navigateByUrl('/categories');
  
    })
    
  }

  getCategories()
  {
    this.categoryService.getCategories().subscribe(category => {
      this.category = category;
      
    })
  }

}
