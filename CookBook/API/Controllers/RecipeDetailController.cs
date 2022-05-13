using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeDetailController:ControllerBase
    {
        private readonly IRecipeDetailService _service;

        public RecipeDetailController(IRecipeDetailService service)
        {
            _service = service;
        }

        [HttpGet("getIngredientsRecipe/{recipeId}")]
      public  List<Models.RecipeDetail> GetIngredients(int recipeId)
        {
            return _service.GetIngredients(recipeId);
        }

    }
}
