using API.Extentions;
using API.Helper;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/Recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<ActionResult<IActionResult>> GetRecipes()
        {
            return Ok(await _recipeService.GetRecipes());
        }

        //  [HttpGet("{recipeName}")]
        [HttpGet("recipeName")]
        public async Task<IActionResult>  GetCategoryByName(string recipeName)
        {
            return Ok(await _recipeService.GetRecipeByName(recipeName));
        }

        [HttpGet("getByCategory/{categoryId}")]
        public async Task<IActionResult> GetByCategory(int categoryId)
        {
            return Ok(await _recipeService.GetByCategory(categoryId));
        }

        [HttpGet("{categoryName}")]

        // [HttpGet("categoryName")]
        public async Task<IActionResult>  GetRecipeByCategory(string categoryName)
        {
            return Ok(await _recipeService.GetRecipeByCategory(categoryName));
        }

        [HttpGet("getById/{id}")]
        public async Task<Models.Recipe> GetRecipeById(int id)
        {
            return await _recipeService.GetRecipeById(id);
        }

        [HttpPost("addRecipe")]
        public async Task<IActionResult> InsertRecipe([FromBody]Models.Recipe request)
        {

            return Ok(await _recipeService.InsertRecipe(request));
        }


        [HttpGet("getIngredientsRecipe/{recipeId}")]
        public async Task<IActionResult> GetIngredients(int recipeId)
        {
            return Ok(await _recipeService.GetIngredients(recipeId));
        }

        [HttpGet("getRecipesPage/{categoryId}")]

       
        public async Task<ActionResult<IEnumerable<Models.Recipe>>> GetRecipeByCategoryPaged(int categoryId, [FromQuery] PaginationParams paginationP)

        {
            var recipes = await _recipeService.GetRecipeByCategoryPaged(categoryId, paginationP);
            Response.AddPaginationHeader(recipes.CurrentPage, recipes.PageSize, recipes.TotalCount, recipes.TotalPages);
            return Ok(recipes);

        }


    }
}
