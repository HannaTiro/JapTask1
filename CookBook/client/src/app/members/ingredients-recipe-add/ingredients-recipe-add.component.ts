import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Ingredient } from 'src/app/_models/ingredient';
import { IngredientService } from 'src/app/_services/ingredient.service';
import { RecipeDetailService } from 'src/app/_services/recipe-detail.service';

@Component({
  selector: 'app-ingredients-recipe-add',
  templateUrl: './ingredients-recipe-add.component.html',
  styleUrls: ['./ingredients-recipe-add.component.css']
})
export class IngredientsRecipeAddComponent implements OnInit {
  @ViewChild('addForm') addForm:NgForm; 
  ingredients: Ingredient[];
units: string[];
ingreientAddForm:FormGroup;
recipeId;
changeIgredient:any;
changeMeasure:any;

  constructor(private ingredientService: IngredientService, 
              private route:ActivatedRoute,
              private recipeDetailService:RecipeDetailService,
              private fb:FormBuilder,
              private router:Router) { 

                this.recipeId = this.route.snapshot.paramMap.get('recipeId');
              }


  ngOnInit(): void {
    this.getIngredients();
    this.getUnits();
    this.initializeForm();
  }

  initializeForm(){
    this.ingreientAddForm=this.fb.group({
      id: ['',Validators.required],
      amount:['',Validators.required],
      measure:['',Validators.required ]

    })
  }
  ChangeIgredient(e)
  {
console.log(e.target.value);
this.changeIgredient=e.target.value;
  }

  ChangeMeasure(e)
  {
console.log(e.target.value);
this.changeMeasure=e.target.value;
  }

  getIngredients() {
    this.ingredientService.getIngredients().subscribe(ingredient => {
      this.ingredients=ingredient;
    })
  }
  getUnits() {
    this.ingredientService.loadUnits().subscribe(unit => {
      this.units=unit;
    })
  }
  addIngredient()
  {
    console.log(this.ingreientAddForm.value);
    this.recipeDetailService.addIngredient(this.recipeId,this.ingreientAddForm.value).subscribe(()=>{
      this.router.navigateByUrl('/recipe/'+this.recipeId);
    })
  
  }

  
}