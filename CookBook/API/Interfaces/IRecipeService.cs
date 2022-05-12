using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public interface IRecipeService
    {
        List<Models.Recipe> GetRecipes();
       Task< Models.Recipe> GetRecipeById(int id);
        Models.Recipe GetRecipeByName(string recipeName);

       List< Models.Recipe> GetRecipeByCategory(string categoryName);
       Task<List<Recipe>> GetByCategory(int id);
    }
}
