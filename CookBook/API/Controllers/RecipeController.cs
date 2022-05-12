using API.Interfaces;
using API.Models;
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

    }
}
