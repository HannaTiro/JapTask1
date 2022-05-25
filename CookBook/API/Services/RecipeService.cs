using API.Entities;
using API.Helper;
using API.Interfaces;
using API.Requests;
using API.Requests.Recipe;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        //public async Task<PagedList<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId,PaginationParams paginationP)
        //{
        //    var query = _context.Recipes.Include(x=>x.Category).Where(y=>y.CategoryId==categoryId).ProjectTo<Models.Recipe>(_mapper.ConfigurationProvider)
        //     .AsQueryable().AsNoTracking();
        //    query = paginationP.OrderBy switch
        //    {
        //       _ => query.OrderBy(u => u.TotalPrice)
        //    };
        //    return await PagedList<Models.Recipe>.CreateAsync(query, paginationP.PageNumber, paginationP.PageSize);


        //}
        public async Task<PagedResult<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId,BaseSearch search)
        {
            var res = new PagedResult<Models.Recipe>();
            var query = _context.Recipes.Include(x => x.Category).Where(y => y.CategoryId == categoryId).AsQueryable();
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
            res.Results = _mapper.Map<IReadOnlyList<Models.Recipe>>(result);
            return res;

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

        public async Task<PagedResult<Models.RecipeDetail>> GetPage(RecipeSearchRequest search)
        {
            var res = new PagedResult<Models.RecipeDetail>();
            var query = _context.RecipeDetails.Include(x => x.Recipe).Include(x => x.Ingredient).AsQueryable();
            var listIngredients = query.ToList();

            //filtering
            if (!string.IsNullOrEmpty(search.RecipeName))
            {
                query = query.Where(x => x.Recipe.Name.Contains(search.RecipeName));
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
                if (search.SortOrder == SortOrder.Ascending)
                {
                    query = query.OrderBy(x=>x.Price);
                }
                else
                {
                    query = query.OrderByDescending(x=>x.Price);
                }
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
            res.Results = _mapper.Map<IReadOnlyList<Models.RecipeDetail>>(result);
            return res;
        }
    }
}
