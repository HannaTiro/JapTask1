using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public interface IRecipeDetailService
    {
        List<Models.RecipeDetail> GetIngredients(int recipeId);


    }
}
