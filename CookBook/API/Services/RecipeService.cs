using API.Entities;
using API.Interfaces;
using API.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class RecipeService : IRecipeService
    {
        protected readonly CookBookContext _context;
        protected readonly IMapper _mapper;
        public RecipeService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Models.Recipe>> GetByCategory(int categoryId)
        {
            var recipe = await _context.Recipes.Where(j => j.CategoryId == categoryId).ToListAsync();

            return _mapper.Map<List<Models.Recipe>>(recipe);
        }

        public List<Models.Recipe> GetRecipeByCategory(string categoryName)
        {
            var recipes = _context.Recipes.Include(x => x.Category).AsQueryable();
            recipes = recipes.Where(y => y.Category.CategoryName.Equals(categoryName));
            var list = recipes.ToList();
            return _mapper.Map<List<Models.Recipe>>(recipes);

        }

        public async Task< Models.Recipe> GetRecipeById(int id)
        {
            var recipe = await _context.Recipes.Include(x=>x.Category).Where(x => x.RecipeId == id).FirstOrDefaultAsync();
            return _mapper.Map<Models.Recipe>(recipe);
        }

        public  Models.Recipe GetRecipeByName(string recipeName)
        {
            var cat = _context.Recipes.Where(j => j.RecipeName == recipeName).FirstOrDefault();

            return _mapper.Map<Models.Recipe>(cat);
        }

        public List<Models.Recipe> GetRecipes()
        {
            var query = _context.Recipes.Include(x=>x.Category)
             .AsQueryable();


            var list = query.ToList();
            return _mapper.Map<List<Models.Recipe>>(list);
        }
    }
}
