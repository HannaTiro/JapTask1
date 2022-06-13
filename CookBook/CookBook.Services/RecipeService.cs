using AutoMapper;
using CookBook.Common.Helper;
using CookBook.Core.Interfaces;
using CookBook.Core.Models.Requests.Recipe;
using CookBook.Core.Models.Requests.SearchObjects;
using CookBook.Database.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Services
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
        public async Task<List<Core.Models.Recipe>> GetByCategoryId(int categoryId)
        {
            var recipe = await _context.Recipes.Where(j => j.CategoryId == categoryId).ToListAsync();
            return _mapper.Map<List<Core.Models.Recipe>>(recipe);
        }
        public async Task<List<Core.Models.Recipe>> GetRecipeByCategory(string categoryName)
        {
            var recipes = _context.Recipes.Include(x => x.Category).AsQueryable();
            recipes = recipes.Where(y => y.Category.Name.Equals(categoryName));

            var list = await recipes.ToListAsync();
            return _mapper.Map<List<Core.Models.Recipe>>(recipes);

        }
        public async Task<PagedResult<Core.Models.Recipe>> GetRecipeByCategoryPaged(RecipeSearch search)
        {
            var res = new PagedResult<Core.Models.Recipe>();
            var query = _context.Recipes
                .Include(x => x.Category)
                .Where(y => y.CategoryId == search.CategoryId)
                .AsQueryable();
            query = query.OrderBy(x => x.TotalPrice);
            //include counter
            if (search.IncludeCount == true)
            {
                res.Count = query.Count();
            }

            //paging
            if (search.RetriveAll.GetValueOrDefault(false) == true)
            {
                if (search.Page < 0)
                    search.Page = 0;
                query = query.Skip((int)((search.Page - 1) * search.PageSize)).Take((int)(search.PageSize));

            }
            var result = await query.ToListAsync();
            res.Results = _mapper.Map<IReadOnlyList<Core.Models.Recipe>>(result);
            return res;

        }
        public async Task<Core.Models.Recipe> GetRecipeById(int id)
        {
            var recipe = await _context.Recipes
                .Include(x=>x.Category)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<Core.Models.Recipe>(recipe);
        }
        public async Task<Core.Models.Recipe> GetRecipeByName(string recipeName)
        {
            var cat = await _context.Recipes.Where(j => j.Name == recipeName).FirstOrDefaultAsync();
            return _mapper.Map<Core.Models.Recipe>(cat);
        }
        public async Task<List<Core.Models.Recipe>> GetRecipes()
        {
            var list = await _context.Recipes.Include(x=>x.Category).ToListAsync();
            return _mapper.Map<List<Core.Models.Recipe>>(list);
        }
        public  async Task<ActionResult<Core.Entities.Recipe>> InsertRecipe(Core.Models.Recipe request)
        {
            var recipe = new Core.Entities.Recipe
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                Description = request.Description,
                TotalPrice=0
               
            };
           _context.Recipes.Add(recipe);
           await _context.SaveChangesAsync();

            return _mapper.Map<Core.Entities.Recipe>(recipe);
        }
        public async Task<PagedResult<Core.Models.RecipeDetail>> GetPage(RecipeSearchRequest search)
        {
            var res = new PagedResult<Core.Models.RecipeDetail>();
            var query = _context.RecipeDetails.Include(x => x.Recipe).Include(x => x.Ingredient).AsQueryable();
            var listIngredients = query.ToList();

            //filtering
            if (!string.IsNullOrEmpty(search.RecipeName))
            {
                query = query.Where(x => x.Recipe.Name.ToUpper().Contains(search.RecipeName.Trim().ToUpper()));
            }

            if (!string.IsNullOrEmpty(search.Description))
            {
                query = query.Where(x => x.Recipe.Description.ToUpper().Contains(search.Description.Trim().ToUpper()));
            }

            if (!string.IsNullOrEmpty(search.IngredientName))
            {
              query = query.Where(x => x.Ingredient.Name.ToUpper().StartsWith(search.IngredientName.Trim().ToUpper()));
            }

            // var list = query.ToList();
            //  return _mapper.Map<List<Models.RecipeDetail>>(lista);

            //ordering
            //if (!string.IsNullOrWhiteSpace(search.SortBy))
            //{
                //if (search.SortOrder == SortOrder.Ascending)
                //{
                //    query = query.OrderBy(x=>x.Price);
                //}
                //else
                //{
                //    query = query.OrderByDescending(x=>x.Price);
                //}
           // }

            //include counter
            if (search.IncludeCount==true)
            {
                res.Count = query.Count();
            }

            //paging
            if (search.RetriveAll.GetValueOrDefault(false)==true)
            {
                if (search.Page < 0)
                    search.Page = 0;
                query = query.Skip((int)((search.Page - 1) * search.PageSize)).Take((int)(search.PageSize));

            }
          

           var result =await  query.ToListAsync();
            res.Results = _mapper.Map<IReadOnlyList<Core.Models.RecipeDetail>>(result);
            return res;
        }

      
    }
}
