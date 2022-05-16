using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Requests.Recipe
{
    public class RecipeSearchRequest
    {
   
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string IngredientName { get; set; }

    }
}
