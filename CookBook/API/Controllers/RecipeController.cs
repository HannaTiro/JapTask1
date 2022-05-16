using API.Extentions;
using API.Helper;
using API.Interfaces;
using API.Models;
using API.Requests.Recipe;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Models.Recipe>> GetRecipes()
        {
            return _service.GetRecipes();
        }

        //  [HttpGet("{recipeName}")]
        [HttpGet("recipeName")]
        public Models.Recipe GetCategoryByName(string recipeName)
        {
            return _service.GetRecipeByName(recipeName);
        }

        [HttpGet("getByCategory/{categoryId}")]
        public async Task<IActionResult> GetByCategory(int categoryId)
        {
            return Ok(await _service.GetByCategory(categoryId));
        }

        [HttpGet("{categoryName}")]

        // [HttpGet("categoryName")]
        public List<Models.Recipe> GetRecipeByCategory(string categoryName)
        {
            return _service.GetRecipeByCategory(categoryName);
        }

        [HttpGet("getById/{id}")]
        public async Task<Models.Recipe> GetRecipeById(int id)
        {
            return await _service.GetRecipeById(id);
        }

        [HttpPost("addRecipe")]
        public async Task<IActionResult> InsertRecipe([FromBody]Models.Recipe request)
        {

            return Ok(await _service.InsertRecipe(request));
        }


        [HttpGet("getIngredientsRecipe/{recipeId}")]
        public List<Models.RecipeDetail> GetIngredients(int recipeId)
        {
            return _service.GetIngredients(recipeId);
        }

        [HttpGet("getRecipesPage/{categoryId}")]

       
        public async Task<ActionResult<IEnumerable<Models.Recipe>>> GetRecipeByCategoryPaged(int categoryId, [FromQuery] PaginationParams paginationP)

        {
            var recipes = await _service.GetRecipeByCategoryPaged(categoryId, paginationP);
            Response.AddPaginationHeader(recipes.CurrentPage, recipes.PageSize, recipes.TotalCount, recipes.TotalPages);
            return Ok(recipes);

        }


    }
}
