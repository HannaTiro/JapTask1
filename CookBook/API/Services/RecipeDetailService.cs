using API.Entities;
using API.Helper;
using API.Interfaces;
using API.Requests.RecipeDetail;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Models.RecipeDetail>> GetIngredients(int recipeId)
        {
            var request = _context.RecipeDetails.Include(x => x.Recipe).Include(x => x.Ingredient).Where(x => x.Recipe.Id == recipeId).AsQueryable();
            var list =  await request.ToListAsync();
            return _mapper.Map<List<Models.RecipeDetail>>(list);

        }
        public  async Task<ActionResult<Models.RecipeDetail>> InsertIngredient(int recipeId, InsertIngredientRequest request)
        {
                var recipe = _context.Recipes.Find(recipeId);
                var entity = new RecipeDetail
                {
                    RecipeId = recipeId,
                    Amount = request.Amount,
                    IngredientId = request.Id,
                    Measure = request.Measure
                };
              // entity.Price = GetPrice(entity.RecipeDetai entity.IngredientId);
               entity.Price = GetPrice(request.Measure, request.Amount, request.Id);
               
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
        public  decimal GetPrice(UnitsEnum measure, int amount,int ingredientId)
        {
         //   var recipeDetail = _context.RecipeDetails.Find(recipeDetailId);
            var ingredient = _context.Ingredients.Find(ingredientId);

            // var recipeDetailUnit = recipeDetail.Measure;
            //var recipeDetailAmount = recipeDetail.Amount;
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
        public async Task<List<Models.RecipeDetail>> GetIngredientsForRecipe(int recipeId)
        {
            var request = _context.RecipeDetails.Include(x => x.Recipe).Include(x => x.Ingredient).Where(x => x.Recipe.Id == recipeId).AsQueryable();
            var list = await request.ToListAsync();
            return _mapper.Map<List<Models.RecipeDetail>>(list);
        }
    }
}
