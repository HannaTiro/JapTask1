using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class RecipeDetail
    {
        public int RecipeDetailId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Amount { get; set; }
        public string Measure { get; set; }
        public decimal Price { get; set; }

        public  Ingredient Ingredient { get; set; }
        public  Recipe Recipe { get; set; }
    }
}
