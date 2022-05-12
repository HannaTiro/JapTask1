﻿using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class Recipe
    {
        public Recipe()
        {
            RecipeDetails = new HashSet<RecipeDetail>();
        }

        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<RecipeDetail> RecipeDetails { get; set; }
    }
}
