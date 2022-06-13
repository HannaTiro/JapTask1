using CookBook.Common.Helper;
using CookBook.Core.Entities;
using CookBook.Core.Models.Requests.Recipe;
using CookBook.Core.Models.Requests.SearchObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Core.Interfaces
{
    public interface IRecipeService
    {
       Task<List<Core.Models.Recipe>> GetRecipes();
       Task<Core.Models.Recipe> GetRecipeById(int id);
       Task<Core.Models.Recipe> GetRecipeByName(string recipeName);
       Task<List<Core.Models.Recipe>> GetRecipeByCategory(string categoryName);
       Task<List<Core.Models.Recipe>> GetByCategoryId(int id);
       Task<ActionResult<Entities.Recipe>> InsertRecipe(CookBook.Core.Models.Recipe request);
        // Task<PagedList<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId, PaginationParams paginationP);
       Task<PagedResult<Models.Recipe>> GetRecipeByCategoryPaged(RecipeSearch search);
       Task<PagedResult<Models.RecipeDetail>> GetPage(RecipeSearchRequest search);




    }
}
