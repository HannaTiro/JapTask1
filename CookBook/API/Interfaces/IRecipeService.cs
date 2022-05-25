﻿using API.Helper;
using API.Models;
using API.Requests;
using API.Requests.Recipe;
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
        // Task<PagedList<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId, PaginationParams paginationP);
        Task<PagedResult<Models.Recipe>> GetRecipeByCategoryPaged(int categoryId, BaseSearch search);

        Task<PagedResult<Models.RecipeDetail>> GetPage(RecipeSearchRequest search);




    }
}
