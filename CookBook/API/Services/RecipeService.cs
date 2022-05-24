using API.Entities;
using API.Helper;
using API.Interfaces;
using API.Models;
using API.Requests.Recipe;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<List<Models.Recipe>> GetRecipeByCategory(string categoryName)
        {
            var recipes = _context.Recipes.Include(x => x.Category).AsQueryable();
            recipes = recipes.Where(y => y.Category.Name.Equals(categoryName));
            
            var list = await recipes.ToListAsync();
            return  _mapper.Map<List<Models.Recipe>>(recipes);

        }
        public async Task<PagedList<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId,PaginationParams paginationP)
        {
            var query = _context.Recipes.Include(x=>x.Category).Where(y=>y.CategoryId==categoryId).ProjectTo<Models.Recipe>(_mapper.ConfigurationProvider)
             .AsQueryable().AsNoTracking();
            query = paginationP.OrderBy switch
            {
               _ => query.OrderBy(u => u.TotalPrice)
            };
            return await PagedList<Models.Recipe>.CreateAsync(query, paginationP.PageNumber, paginationP.PageSize);


        }
        public async Task< Models.Recipe> GetRecipeById(int id)
        {
            var recipe = await _context.Recipes.Include(x=>x.Category).Where(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<Models.Recipe>(recipe);
        }
        public async Task<Models.Recipe> GetRecipeByName(string recipeName)
        {
            var cat = await _context.Recipes.Where(j => j.Name == recipeName).FirstOrDefaultAsync();
            return _mapper.Map<Models.Recipe>(cat);
        }
        public async Task<List<Models.Recipe>> GetRecipes()
        {
            var query = _context.Recipes.Include(x=>x.Category).AsQueryable();
            var list =await query.ToListAsync();
            return _mapper.Map<List<Models.Recipe>>(list);
        }
        public  async Task<ActionResult<Entities.Recipe>> InsertRecipe(Models.Recipe request)
        {
            var model = new Entities.Recipe
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                Description = request.Description,
                TotalPrice=0
               
            };
           _context.Recipes.Add(model);
           await _context.SaveChangesAsync();

            return _mapper.Map<Entities.Recipe>(model);
        }
    }
}
