using API.Interfaces;
using API.Requests.RecipeDetail;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/RecipeDetails")]
    [ApiController]
    public class RecipeDetailController:ControllerBase
    {
        private readonly IRecipeDetailService _recipeDetailService;

        public RecipeDetailController(IRecipeDetailService recipeDetailService)
        {
            _recipeDetailService = recipeDetailService;
        }

        [HttpGet("getIngredientsRecipe/{recipeId}")]
        public async Task<IActionResult> GetIngredients(int recipeId)
        {
            return Ok(await _recipeDetailService.GetIngredients(recipeId));
        }

        [HttpPost("addIngredient/{recipeId}")]
        public async Task<IActionResult> InsertIngredient(int recipeId, [FromBody]InsertIngredientRequest request)
        {
            return Ok(await _recipeDetailService.InsertIngredient(recipeId, request));
        }


    }
}
