using API.Entities;
using API.Interfaces;
using API.Requests.RecipeDetail;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class RecipeDetailService:IRecipeDetailService
    {

        protected readonly CookBookContext _context;
        protected readonly IMapper _mapper;
        public RecipeDetailService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Models.RecipeDetail> GetIngredients(int recipeId)
        {
            var request = _context.RecipeDetails.Include(x => x.Recipe).Include(x => x.Ingredient).Where(x => x.Recipe.RecipeId == recipeId).AsQueryable();
            var list = request.ToList();
            return _mapper.Map<List<Models.RecipeDetail>>(list);

        }

        public  async Task<ActionResult<Models.RecipeDetail>> InsertIngredient(int recipeId, InsertIngredientRequest request)
        {
      
            
             var recipe = _context.Recipes.Find(recipeId);
            
                var entity = new RecipeDetail
                {
                    RecipeId = recipeId,
                    Amount = request.Amount,
                    IngredientId = request.IngredientId,
                    Measure = request.Measure
                   
                  

                };
            // entity.Price = GetPrice(entity.RecipeDetai entity.IngredientId);
           entity.Price = GetPrice(request.Measure, request.Amount, request.IngredientId);
            
                _context.RecipeDetails.Add(entity);
                 await  _context.SaveChangesAsync();

            var recipef = _context.Recipes.Find(recipeId);

            recipef.TotalPrice = GetTotalPrice(recipeId);
                 await _context.SaveChangesAsync();


            return _mapper.Map<Models.RecipeDetail>(entity);
            
            
           }
        public decimal GetTotalPrice(int recipeId)
        {
            var obj = _context.RecipeDetails.Where(x => x.RecipeId == recipeId).ToList();
            decimal price = 0;
            foreach (var item in obj)
            {
                if(item!=null)
                price += (decimal)item.Price;
            }
            return price;
        }
        public  decimal GetPrice(string measure, int amount,int ingredientId)
        {
         //   var recipeDetail = _context.RecipeDetails.Find(recipeDetailId);
            var ingredient = _context.Ingredients.Find(ingredientId);

            // var recipeDetailUnit = recipeDetail.Measure;
            //var recipeDetailAmount = recipeDetail.Amount;
            var recipeDetailUnit = measure;
            var recipeDetailAmount = amount;
            var ingredientAmount = ingredient.Amount;
            var ingredientUnit = ingredient.Measure;
            if(ingredientAmount!=0 && recipeDetailAmount!=0)
            { 
            if(recipeDetailUnit== ingredientUnit)
            {
                  return  ingredient.IngredientPrice/(ingredientAmount / recipeDetailAmount);
                
            }
            else
            { 
                if((recipeDetailUnit=="kg" && ingredientUnit == "g") || (recipeDetailUnit == "l" && ingredientUnit == "ml"))
                {
                    var convert = recipeDetailAmount * 1000;
                    return ingredient.IngredientPrice / (ingredientAmount / convert);
                }
                else if((recipeDetailUnit == "g" && ingredientUnit == "kg" ) || (recipeDetailUnit == "ml" && ingredientUnit == "l"))
                {
                    var convert = ingredientAmount * 1000;
                        var convert2 = convert / recipeDetailAmount;
                        return ingredient.IngredientPrice / convert2;

                }
              
            }
            }
            return 0;
        }
    }
}
