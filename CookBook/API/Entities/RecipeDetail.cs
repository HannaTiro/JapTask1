﻿#nullable disable

namespace API.Entities
{
    public  class RecipeDetail: BaseEntity
    {
        public int Amount { get; set; }
        public string Measure { get; set; }
        public decimal Price { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        public virtual Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
    }
}
