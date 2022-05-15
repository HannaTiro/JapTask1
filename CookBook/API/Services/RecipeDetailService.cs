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

        public async Task<ActionResult<Models.RecipeDetail>> InsertIngredient(int recipeId, InsertIngredientRequest request)
        {
      
            
             var recipe = _context.Recipes.Find(recipeId);
            
                var entity = new RecipeDetail
                {
                    RecipeId = recipe.RecipeId,
                    Amount = request.Amount,
                    IngredientId = request.IngredientId,
                    Measure = request.Measure

                };
          //  entity.Price= //formula
                _context.RecipeDetails.Add(entity);
              await  _context.SaveChangesAsync();
                return _mapper.Map<Models.RecipeDetail>(entity);
            
            
           }
    }
}
