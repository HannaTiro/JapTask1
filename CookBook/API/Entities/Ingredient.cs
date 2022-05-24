﻿using API.Helper;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public  class Ingredient:BaseEntity
    {
        public Ingredient()
        {
            RecipeIngredients = new HashSet<RecipeDetail>();
        }

        
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int PurchaseAmount { get; set; }
        public UnitsEnum PurchaseMeasure { get; set; }
        public virtual ICollection<RecipeDetail> RecipeIngredients { get; set; } 
    }
}
