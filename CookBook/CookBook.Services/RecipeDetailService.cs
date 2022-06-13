using AutoMapper;
using CookBook.Core.Interfaces;
using CookBook.Core.Models.Requests.RecipeDetail;
using CookBook.Database.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Common.Enums;
using CookBook.Core.Entities;

namespace CookBook.Services
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

        public async Task<List<CookBook.Core.Models.RecipeDetail>> GetIngredients(int recipeId)
        {
            var request = _context.RecipeDetails
                .Include(x => x.Recipe)
                .Include(x => x.Ingredient)
                .Where(x => x.RecipeId == recipeId).ToListAsync();
   
            return _mapper.Map<List<CookBook.Core.Models.RecipeDetail>>(request);
        }
        public  async Task<ActionResult<CookBook.Core.Models.RecipeDetail>> InsertIngredient(InsertIngredientRequest request)
        {
                var recipe = _context.Recipes.Find(request.RecipeId);
                var entity = new RecipeDetail
                {
                    RecipeId = request.RecipeId,
                    Amount = request.Amount,
                    IngredientId = request.IngredientId,
                    Measure = request.Measure
                };
              // entity.Price = GetPrice(entity.RecipeDetai entity.IngredientId);
               entity.Price = GetPrice(request.Measure, request.Amount, request.IngredientId);
               
            _context.RecipeDetails.Add(entity);
            await  _context.SaveChangesAsync();
            var recipef = _context.Recipes.Find(request.RecipeId);
            recipef.TotalPrice = GetTotalPrice(request.RecipeId);
            await _context.SaveChangesAsync();

            return _mapper.Map<CookBook.Core.Models.RecipeDetail>(entity);
            
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
        public  decimal GetPrice(UnitsEnum measure, int amount,int ingredientId)
        {
       
            var ingredient = _context.Ingredients.Find(ingredientId);
            var recipeDetailUnit = measure;
            var recipeDetailAmount = amount;
            var ingredientAmount = ingredient.PurchaseAmount;
            var ingredientUnit = ingredient.PurchaseMeasure;
            if(ingredientAmount!=0 && recipeDetailAmount!=0)
            { 
             if(recipeDetailUnit== ingredientUnit)
             {
                  return  ingredient.PurchasePrice/(ingredientAmount / recipeDetailAmount);
             }
             else
             { 
                if((measure.ToString()=="kg" && ingredientUnit.ToString()=="g" ) || (recipeDetailUnit.ToString()=="l" && ingredientUnit.ToString() == "ml"))
                {
                    var convert = recipeDetailAmount * 1000;
                    return ingredient.PurchasePrice / (ingredientAmount / convert);
                }
                else if((recipeDetailUnit.ToString() == "g" && ingredientUnit.ToString() == "kg" ) || (recipeDetailUnit.ToString() == "ml" && ingredientUnit.ToString() == "l"))
                {
                    var convert = ingredientAmount * 1000;
                        var convert2 = convert / recipeDetailAmount;
                        return ingredient.PurchasePrice / convert2;
                }
              
             }
            }
               return 0;
        }
        public async Task<List<CookBook.Core.Models.RecipeDetail>> GetIngredientsForRecipe(int recipeId)
        {
            var request = await _context.RecipeDetails
                .Include(x => x.Recipe)
                .Include(x => x.Ingredient)
                .Where(x => x.RecipeId == recipeId)
                .ToListAsync();
            return _mapper.Map<List<CookBook.Core.Models.RecipeDetail>>(request);
        }
    }
}
