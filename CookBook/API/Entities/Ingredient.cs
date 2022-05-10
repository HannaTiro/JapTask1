using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            RecipeDetails = new HashSet<RecipeDetail>();
        }

        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientPrice { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<RecipeDetail> RecipeDetails { get; set; }
    }
}
