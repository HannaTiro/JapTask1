using CookBook.Core.Models.Requests.RecipeDetail;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Core.Interfaces
{
    public interface IRecipeDetailService
    {
        Task<List<Models.RecipeDetail>> GetIngredients(int recipeId);
        Task<ActionResult<Models.RecipeDetail>> InsertIngredient(InsertIngredientRequest request);
        Task<List<Models.RecipeDetail>> GetIngredientsForRecipe(int recipeId);
    }
}
