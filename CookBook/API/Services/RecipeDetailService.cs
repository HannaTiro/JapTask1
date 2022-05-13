using API.Entities;
using API.Interfaces;
using AutoMapper;
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


    }
}
