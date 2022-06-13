using CookBook.Common.Helper;
using CookBook.Core.Interfaces;
using CookBook.Core.Models.Requests.Recipe;
using CookBook.Core.Models.Requests.SearchObjects;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<ActionResult<IActionResult>> GetRecipes()
        {
            return Ok(await _recipeService.GetRecipes());
        }

        ////  [HttpGet("{recipeName}")]
        //[HttpGet("recipeName")]
        //public async Task<IActionResult>  GetCategoryByName(string recipeName)
        //{
        //    return Ok(await _recipeService.GetRecipeByName(recipeName));
        //}

        [HttpGet("getByCategory/{categoryId}")]
        public async Task<IActionResult> GetByCategory(int categoryId)
        {
            return Ok(await _recipeService.GetByCategoryId(categoryId));
        }

        //[HttpGet("{categoryName}")]
        //public async Task<IActionResult>GetRecipeByCategory(string categoryName)
        //{
        //    return Ok(await _recipeService.GetRecipeByCategory(categoryName));
        //}

        [HttpGet("getById/{id}")]
        public async Task<CookBook.Core.Models.Recipe> GetRecipe(int id)
        {
            return await _recipeService.GetRecipeById(id);
        }

        [HttpPost("addRecipe")]
        public async Task<IActionResult> InsertRecipe([FromBody] CookBook.Core.Models.Recipe request)
        {

            return Ok(await _recipeService.InsertRecipe(request));
        }

        [HttpGet("page/{categoryId}")]
        //public async Task<ActionResult<IEnumerable<Models.Recipe>>> GetPage(int categoryId, [FromQuery] PaginationParams paginationP)
        //{
        //    var recipes = await _recipeService.GetRecipeByCategoryPaged(categoryId, paginationP);
        //    Response.AddPaginationHeader(recipes.CurrentPage, recipes.PageSize, recipes.TotalCount, recipes.TotalPages);
        //    return Ok(recipes);
        //}
        public async Task<PagedResult<CookBook.Core.Models.Recipe>> GetRecipeByCategoryPaged([FromQuery] RecipeSearch search)
        {
            return await _recipeService.GetRecipeByCategoryPaged(search);
        }
        [HttpGet("page")]
        public async Task<PagedResult<CookBook.Core.Models.RecipeDetail>> GetPage([FromQuery]RecipeSearchRequest search)
        {
            return await _recipeService.GetPage(search);
        }


    }
}
