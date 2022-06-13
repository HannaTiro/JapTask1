﻿using CookBook.Core.Interfaces;
using CookBook.Core.Models.Requests.RecipeDetail;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeDetailsController:ControllerBase
    {
        private readonly IRecipeDetailService _recipeDetailService;

        public RecipeDetailsController(IRecipeDetailService recipeDetailService)
        {
            _recipeDetailService = recipeDetailService;
        }

        [HttpGet("getIngredientsRecipe/{recipeId}")]
        public async Task<IActionResult> GetIngredients(int recipeId)
        {
            return Ok(await _recipeDetailService.GetIngredients(recipeId));
        }

        [HttpPost("addIngredient")]
        public async Task<IActionResult> InsertIngredient([FromBody]InsertIngredientRequest request)
        {
            return Ok(await _recipeDetailService.InsertIngredient (request));
        }

        [HttpGet("getIngredientsForRecipe/{recipeId}")]
        public async Task<IActionResult> GetIngredientsForRecipe(int recipeId)
        {
            return Ok(await _recipeDetailService.GetIngredientsForRecipe(recipeId));
        }


    }
}
