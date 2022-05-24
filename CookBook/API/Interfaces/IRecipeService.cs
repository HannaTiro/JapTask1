using API.Helper;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IRecipeService
    {
       Task<List<Models.Recipe>> GetRecipes();
       Task< Models.Recipe> GetRecipeById(int id);
       Task<Models.Recipe> GetRecipeByName(string recipeName);
       Task<List< Models.Recipe>> GetRecipeByCategory(string categoryName);
       Task<List<Recipe>> GetByCategory(int id);
       Task<ActionResult<Entities.Recipe>> InsertRecipe(Models.Recipe request);
       Task<PagedList<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId, PaginationParams paginationP);
       // List<Models.Recipe> GetRecipesSearch(RecipeSearchRequest request);

    }
}
