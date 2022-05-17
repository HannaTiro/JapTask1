using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class RecipeDetail
    {
        public int RecipeDetailId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Amount { get; set; }
        public string Measure { get; set; }
        public decimal Price { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
